//
// Helper classes (C# wrappers)
//
#pragma warning disable CS1587
#pragma warning disable CS1591

using System;
using RDF;

namespace NAMESPACE_NAME
{
// Classes list:
//## TEMPLATE: ClassForwardDeclaration (not really required in C#)
//     CLASS_NAME
//## TEMPLATE: BeginAllClasses - empty in C#
//## TEMPLATE: BeginWrapperClass

    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class CLASS_NAME
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class CLASS_NAME : /*BASE CLASS*/Instance
    {
        /// <summary>
        /// Create new instace of OWL class CLASS_NAME and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new CLASS_NAME Create(Int64 model, string name=null) { return new CLASS_NAME(Instance.Create(model, "CLASS_NAME", name), "CLASS_NAME");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public CLASS_NAME(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "CLASS_NAME") 
        {            
        }

        public static implicit operator CLASS_NAME(Int64 instance) => new CLASS_NAME(instance);

        //## TEMPLATE StartPropertiesBlock

        //
        // Properties with known cardinality restrictions to PROPERTIES_OF_CLASS
        //

//## TEMPLATE SetDataProperty
        public bool Set_PROPERTY_NAME(double? value) {  return SetDatatypeProperty("PROPERTY_NAME", value); }
//## TEMPLATE SetDataArrayProperty
        public bool Set_PROPERTY_NAME(double[] value) {  return SetDatatypeProperty("PROPERTY_NAME", value); }
//## TEMPLATE GetDataProperty
        ///<summary>Access value of PROPERTY_NAME</summary>
        public double? PROPERTY_NAME
            {
            set { if (!SetDatatypeProperty("PROPERTY_NAME", value)) throw new SetPropertyException("PROPERTY_NAME", m_instance); }
            get { var arr = GetDatatypeProperty_double("PROPERTY_NAME"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
//## TEMPLATE GetDataArrayProperty
        ///<summary>Access values of PROPERTY_NAME. OWL cardinality CARDINALITY_MIN..CARDINALITY_MAX</summary>
        public double[] PROPERTY_NAme
            {
            set { if (!SetDatatypeProperty("PROPERTY_NAME", value)) throw new SetPropertyException("PROPERTY_NAME", m_instance); }
            get { return GetDatatypeProperty_double("PROPERTY_NAME"); }
            }
//## TEMPLATE SetObjectProperty
        public bool Set_PROPERTY_NAME(Int64 value) {  return SetObjectProperty("PROPERTY_NAME", value); }

//## TEMPLATE SetObjectArrayProperty
        public bool Set_PROPERTY_NAME(Instance[] value) {  return SetObjectProperty("PROPERTY_NAME", value); }
//## TEMPLATE GetObjectProperty
        ///<summary>Access relationship from this instance to an instance of Instance</summary>
        public Instance PROPERTY_NAMEasTYPE_sufix
            {
            set
                {
                if (!SetObjectProperty("PROPERTY_NAME", value)) throw new SetPropertyException("PROPERTY_NAME", m_instance);
                }
            get
                {
                var propId = GetPropertyId("PROPERTY_NAME");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Instance(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
//## TEMPLATE GetObjectArrayProperty
        ///<summary>Access an array of related instances. OWL cardinality CARDINALITY_MIN..CARDINALITY_MAX</summary>
        public Instance[] PROPERTY_NAMEasType_sufix
            {
            set
                {
                if (!SetObjectProperty("PROPERTY_NAME", value)) throw new SetPropertyException("PROPERTY_NAME", m_instance);
                }
            get
                {
                var propId = GetPropertyId("PROPERTY_NAME");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Instance[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Instance(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

//## TEMPLATE GetObjectArrayPropertyInt64
        ///<summary>Access an array of handles of related instances. OWL cardinality CARDINALITY_MIN..CARDINALITY_MAX</summary>
        public Int64[] PROPERTY_NAME_h
        {
            set
                {
                if (!SetObjectProperty("PROPERTY_NAME", value)) throw new SetPropertyException("PROPERTY_NAME", m_instance);
                }
            get
                {
                var propId = GetPropertyId("PROPERTY_NAME");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    return values;
                    }
                else
                    {
                    return null;
                    }
                }
        }
//## TEMPLATE: EndWrapperClass
    }

//## TEMPLATE: EndFile template part

    /// <summary>
    /// Provides utility methods to interact with a genetic instance of OWL class
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Instance : IEquatable<Instance>, IComparable, IComparable<Instance>
    {
        /// <summary>
        /// Create an instance of specified class
        /// </summary>
        public static Int64 Create(Int64 model, string className, string instanceName)
        {
            Int64 clsid = engine.GetClassByName(model, className);
            System.Diagnostics.Debug.Assert(clsid != 0);

            Int64 instance = engine.CreateInstance(clsid, instanceName);
            System.Diagnostics.Debug.Assert(instance != 0);

            return instance;
        }

        /// <summary>
        /// Create an instance of specified class
        /// </summary>
        public static Int64 Create(Int64 model, string className) { return Create(model, className, null); }

        /// <summary>
        /// underlyed instance handle
        /// </summary>
        protected Int64 m_instance = 0;

        /// <summary>
        /// Constructs object that wraps existing OWL instance
        /// </summary>
        public Instance(Int64 instance, string cls)
        {
            m_instance = instance;
            if (cls != null && !engine.IsInstanceOfClass(instance, cls))
            {
                m_instance = 0;
            }
        }


        /// <summary>
        /// Conversion to instance handle, so the object of the class can be used anywhere where a handle required
        /// </summary>
        public static implicit operator Int64(Instance instance) => instance.m_instance;

        /// <summary>
        /// Get exact name of instance class
        /// </summary>
        public string _className
            {
            get
                {
                if (m_instance != 0)
                    {
                    var cls = engine.GetInstanceClass(m_instance);
                    if (cls!= 0)
                        {
                        return engine.GetNameOfClass(cls);
                        }
                    }
                return null;
                }
            }

        /// <summary>
        /// Get property id from property name
        /// </summary>
        public Int64 GetPropertyId(string name, Int64 checkCardinality = -1)
        {
            var model = engine.GetModel(m_instance);
            var propId = engine.GetPropertyByName(model, name);
            if (propId != 0)
            {
                var clsId = engine.GetInstanceClass(m_instance);
                Int64 minCard = 0, maxCard = 0;
                engine.GetClassPropertyAggregatedCardinalityRestriction(clsId, propId, out minCard, out maxCard);
                if (minCard < 0)
                {
                    propId = 0; //property is not assigned to the class
                }
                if (checkCardinality > 0)
                { //chek cardinatity when set property
                    if (checkCardinality < minCard || (maxCard > 0 && checkCardinality > maxCard))
                    {
                        propId = 0; //cardinality is out of range
                    }
                }
            }

            return propId;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool SetDatatypeProperty(string name, double? value)
        {
            var propId = GetPropertyId(name, 1);
            double val = 0;
            Int64 card = 0;
            if (value.HasValue)
                {
                val = value.Value;
                card = 1;
                }
            var res = engine.SetDatatypeProperty(m_instance, propId, ref val, card);
            return(res == 0);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool SetDatatypeProperty(string name, double[] values)
        {
            var propId = GetPropertyId(name, values.Length);
            var res = engine.SetDatatypeProperty(m_instance, propId, values, values.Length);
            return(res == 0);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool SetDatatypeProperty(string name, Int64? value)
        {
            var propId = GetPropertyId(name, 1);
            Int64 val = 0;
            Int64 card = 0;
            if (value.HasValue)
                {
                val = value.Value;
                card = 1;
                }
            var res = engine.SetDatatypeProperty(m_instance, propId, ref val, card);
            return(res == 0);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool SetDatatypeProperty(string name, Int64[] values)
        {
            var propId = GetPropertyId(name, values.Length);
            var res = engine.SetDatatypeProperty(m_instance, propId, values, values.Length);
            return(res == 0);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool SetDatatypeProperty(string name, bool? value)
        {
            var propId = GetPropertyId(name, 1);
            byte val = 0;
            Int64 card = 0;
            if (value.HasValue)
                {
                val = (byte)(value.Value ? 1 : 0); ;
                card = 1;
                }
            var res = engine.SetDatatypeProperty(m_instance, propId, ref val, card);
            return(res == 0);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool SetDatatypeProperty(string name, bool[] values)
        {
            byte[] bytes = new byte[values.Length];
            for (int i = 0; i < values.Length; i++)
                bytes[i] = values[i] ? (byte)1 : (byte)0;

            var propId = GetPropertyId(name, values.Length);
            var res = engine.SetDatatypeProperty(m_instance, propId, bytes, values.Length);
            return(res == 0);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool SetDatatypeProperty(string name, string value)
        {
            var propId = GetPropertyId(name, 1);
            var res = engine.SetDatatypeProperty(m_instance, propId, ref value, 1);
            return(res == 0);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool SetDatatypeProperty(string name, string[] values)
        {
            var propId = GetPropertyId(name, values.Length);
            var res = engine.SetDatatypeProperty(m_instance, propId, values, values.Length);
            return(res == 0);
        }

        /// <summary>
        /// 
        /// </summary>
        public double[] GetDatatypeProperty_double(string name)
        {
            var propId = GetPropertyId(name);

            Int64 card = 0;
            IntPtr valuesPtr = IntPtr.Zero;
            var res = engine.GetDatatypeProperty(m_instance, propId, out valuesPtr, out card);
            if (res != 0)
            {
                card = 0;
            }

            if (card > 0)
            {
                var values = new double[card];
                System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                return values;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64[] GetDatatypeProperty_Int64(string name)
        {
            var propId = GetPropertyId(name);

            Int64 card = 0;
            IntPtr valuesPtr = IntPtr.Zero;
            var res = engine.GetDatatypeProperty(m_instance, propId, out valuesPtr, out card);
            if(res != 0)
            {
                card = 0;
            }

            if (card > 0)
            {
                var values = new Int64[card];
                System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                return values;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool[] GetDatatypeProperty_bool(string name)
        {
            var propId = GetPropertyId(name);

            Int64 card = 0;
            IntPtr valuesPtr = IntPtr.Zero;
            var res = engine.GetDatatypeProperty(m_instance, propId, out valuesPtr, out card);
            if(res != 0)
            {
                card = 0;
            }

            if (card > 0)
            {
                var values = new byte[card];
                System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                var bools = new bool[card];
                for (int i = 0; i < card; i++)
                {
                    bools[i] = values[i] != 0;
                }

                return bools;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string[] GetDatatypeProperty_string(string name)
        {
            var propId = GetPropertyId(name);

            Int64 card = 0;
            IntPtr valuesPtr = IntPtr.Zero;
            var res = engine.GetDatatypeProperty(m_instance, propId, out valuesPtr, out card);
            if(res != 0)
            {
                card = 0;
            }

            if (card > 0)
            {
                var values = new IntPtr[card];
                System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                var strings = new string[card];
                for (int i = 0; i < (int)card; i++)
                {
                    strings[i] = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(values[i]);
                }
                return strings;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool SetObjectProperty(string name, Int64 instance)
        {
            var propId = GetPropertyId(name);
            var res = engine.SetObjectProperty(m_instance, propId, ref instance, 1);
            return (res == 0);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool SetObjectProperty(string name, Instance[] instances)
        {
            var inst = new Int64[instances.Length];
            for (int i = 0; i < instances.Length; i++)
                inst[i] = instances[i];

            return SetObjectProperty(name, inst);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool SetObjectProperty(string name, Int64[] instances)
        {
            var propId = GetPropertyId(name);

            var inst = new Int64[instances.Length];
            for (int i = 0; i < instances.Length; i++)
                inst[i] = instances[i];

            var res = engine.SetObjectProperty(m_instance, propId, ref inst[0], inst.Length);
            return(res == 0);
        }


        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Instance i1, Instance i2) => (Equals(i1, i2));

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Instance i1, Instance i2) => (!(i1 == i2));

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(Object obj) 
        {
            return Equals(obj as Instance); 
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Instance other)     
        {
            return (other == null) ? false : (other.m_instance == m_instance);
        }

        /// <summary>
        /// 
        /// </summary>
        public int CompareTo(object obj)
        {
            return CompareTo (obj as Instance);
        }

        /// <summary>
        /// 
        /// </summary>
        public int CompareTo(Instance other)
        {
            return (other==null)?1:m_instance.CompareTo (other.m_instance);
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            return m_instance.GetHashCode();
        }
    }

    /// <summary>
    /// Rised when property can not be set
    /// </summary>
    public class SetPropertyException : ApplicationException
        {
        public SetPropertyException(string propName, Int64 instance) : base(FormatMessage(propName, instance)) { }
        static string FormatMessage(string propName, Int64 instance)
            {
            string clsName = "<NULL>";
            if (instance != 0)
                {
                var cls = engine.GetInstanceClass(instance);
                if (cls != 0)
                    {
                    clsName = engine.GetNameOfClass(cls);
                    }
                }

            return $"Failed to set property {propName} to instance of {clsName}";
            }
        }

    }

