﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDFWrappers
{
    class Schema
    {
        public class Property
        {
            public Int64 id;
            public Int64 type;
            public List<Int64> resrtictions = new List<Int64>();

            public string DataType(bool cs)
            {
                switch (type)
                {
                    case RDF.engine.OBJECTPROPERTY_TYPE:             return "Instance";
                    case RDF.engine.DATATYPEPROPERTY_TYPE_BOOLEAN:   return "bool";
                    case RDF.engine.DATATYPEPROPERTY_TYPE_CHAR:      return cs ? "string" : "const char* const";
                    case RDF.engine.DATATYPEPROPERTY_TYPE_INTEGER:   return cs ? "Int64" : "int64_t";
                    case RDF.engine.DATATYPEPROPERTY_TYPE_DOUBLE:    return "double";
                }
                throw new ApplicationException("Unknown property type");
            }

            public bool IsObject() { return type == RDF.engine.OBJECTPROPERTY_TYPE; }
        }

        public class ClassProperty
        {
            public string name;
            public Int64 min;
            public Int64 max;
        }

        public class Class
        {
            public Int64 id;
            public List<Int64> parents = new List<Int64>();
            public List<ClassProperty> properties = new List<ClassProperty>();
        }

        public SortedList<string, Class> m_classes = new SortedList<string, Class>();
        public SortedList<string, Property> m_properties = new SortedList<string, Property>();

        private Int64 m_model = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public Schema (Int64 model)
        {
            m_model = model;

            CollectProperties();
            CollectClasses();
        }

        public string GetNameOfClass (Int64 clsid)
        {
            IntPtr namePtr = IntPtr.Zero;
            RDF.engine.GetNameOfClass(clsid, out namePtr);
            return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(namePtr);
        }

        private void CollectClasses ()
        {
            Int64 clsid = RDF.engine.GetClassesByIterator(m_model, 0);
            while (clsid != 0)
            {
                string name = GetNameOfClass(clsid);

                var cls = new Class();
                cls.id = clsid;
                
                CollectClassParents(cls);

                CollectClassProperties(cls);

                m_classes.Add(name, cls);

                clsid = RDF.engine.GetClassesByIterator(m_model, clsid);
            }
        }

        private void CollectClassParents (Class cls)
        {
            Int64 parent = RDF.engine.GetClassParentsByIterator(cls.id, 0);
            while (parent!=0)
            {
                cls.parents.Add(parent);
                parent = RDF.engine.GetClassParentsByIterator(cls.id, parent);
            }
        }

        private void CollectClassProperties (Class cls)
        {
            foreach (var prop in m_properties)
            {
                Int64 min, max;
                RDF.engine.GetClassPropertyCardinalityRestriction(cls.id, prop.Value.id, out min, out max);

                if (min >= 0)
                {
                    var clsprop = new ClassProperty();

                    clsprop.name = prop.Key;
                    clsprop.min = min;
                    clsprop.max = max;

                    cls.properties.Add(clsprop);
                }
            }
        }

        private void CollectProperties()
        {
            Int64 propid = RDF.engine.GetPropertiesByIterator(m_model, 0);
            while (propid != 0)
            {
                IntPtr namePtr = IntPtr.Zero;
                RDF.engine.GetNameOfProperty(propid, out namePtr);

                string name = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(namePtr);

                Property prop = new Property();
                prop.id = propid;
                prop.type = RDF.engine.GetPropertyType(prop.id);

                var restrict = RDF.engine.GetRangeRestrictionsByIterator(prop.id, 0);
                while (restrict != 0)
                {
                    prop.resrtictions.Add(restrict);
                    restrict = RDF.engine.GetRangeRestrictionsByIterator(prop.id, restrict);
                }
                System.Diagnostics.Debug.Assert( //other cases not testes
                    prop.resrtictions.Count == 0 && !prop.IsObject()
                    || prop.resrtictions.Count == 1 && prop.IsObject());

                m_properties.Add(name, prop);

                propid = RDF.engine.GetPropertiesByIterator(m_model, propid);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ToConsole ()
        {
            Console.WriteLine("-------- Extracted shcema ----------------");
            foreach (var cls in m_classes)
            {
                Console.Write("{0}:", cls.Key);
                foreach (var parent in cls.Value.parents)
                {
                    Console.Write(" {0}", GetNameOfClass(parent));
                }
                Console.WriteLine();

                foreach (var clsprop in cls.Value.properties)
                {
                    var prop = m_properties[clsprop.name];

                    Console.Write("    {0}: {1}", clsprop.name, prop.DataType(true));
                    if (prop.resrtictions.Count > 0)
                    {
                        Console.Write("[");
                        foreach (var r in prop.resrtictions)
                        {
                            string n = GetNameOfClass(r);
                            Console.Write("{0} ", n);
                        }
                        Console.Write("]");
                    }
                    Console.WriteLine(" ({0}-{1})", clsprop.min, clsprop.max);
                }
            }
            Console.WriteLine();
        }
    }
}
