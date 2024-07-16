//
// Helper classes (C# wrappers)
//
#pragma warning disable CS1587
#pragma warning disable CS1591

using System;
using RDF;

namespace GEOM
{
// Classes list:
//     AdvancedFace
//     AdvancedFace2D
//     AdvancedFace3D
//     AdvancedFaceMapped
//     AlignedSegment
//     AlignedSegments
//     Alignment
//     AmbientLight
//     Appearance
//     Arc3D
//     BezierCurve
//     BezierSurface
//     BiQuadraticParabola
//     Blend
//     BlossCurve
//     BooleanOperation
//     BooleanOperation2D
//     BoundaryRepresentation
//     Box
//     BSplineCurve
//     BSplineSurface
//     Circle
//     CircleByPoints
//     ClippedPyramid
//     Clipping
//     Clothoid
//     ClothoidCurve
//     Collection
//     Color
//     ColorComponent
//     Cone
//     ConicalCurve
//     ConicalSurface
//     ConvexPolyhedron
//     Copy
//     CosineCurve
//     Cube
//     CubicParabola
//     Cuboid
//     Curve
//     CurvesFromSurface
//     Cylinder
//     CylindricalSurface
//     DegenerateToroidalSurface
//     Deviation
//     DirectionalLight
//     DirectLight
//     Dummy
//     Ellipse
//     EllipticCone
//     Environment
//     ExtrudedPolygon
//     ExtrudedPolygonTapered
//     ExtrusionAreaSolid
//     ExtrusionAreaSolidSet
//     Face
//     Face2D
//     Face2DSet
//     FiniteSurface
//     FrustumCone
//     GeometricItem
//     HornTorus
//     Hyperbola
//     InfiniteSurface
//     Intersection
//     IntersectionCurve
//     IntersectionPoint
//     InverseMatrix
//     InvertedCurve
//     InvertedSurface
//     Light
//     Line3D
//     Line3Dn
//     Line3DSet
//     Line4D
//     LineByFace
//     Material
//     Mathematics
//     Matrix
//     MatrixMultiplication
//     Mesh
//     Nill
//     NURBSCurve
//     NURBSSurface
//     Parabola
//     Plane
//     PlaneSurface
//     Point
//     Point3D
//     Point3DSet
//     Point3DSetByGeometricItem
//     Point4D
//     PointLight
//     PointLoop
//     Polygon2D
//     Polygon3D
//     Polygon4D
//     PolyLine3D
//     Prism
//     Profile
//     Projection
//     Pyramid
//     RationalBezierCurve
//     RationalBezierSurface
//     RectangleCurve
//     Repetition
//     RingTorus
//     Shadow
//     SineCurve
//     SkewedCone
//     SkewedFrustumCone
//     Solid
//     SolidBySurface
//     SolidLine
//     Sphere
//     SphericalSurface
//     SpindleTorus
//     Spiral
//     SplineCurve
//     SplineSurface
//     SplitConceptualFace
//     SpotLight
//     Surface
//     SurfaceBySweptCurve
//     SurfaceOfLinearExtrusion
//     SurfaceOfRevolution
//     SweptAreaSolid
//     SweptAreaSolidSet
//     SweptAreaSolidTapered
//     SweptBlend
//     SweptDiskSolid
//     Texture
//     ToroidalSurface
//     Torus
//     Transformation
//     TransitionalCurve
//     TriangleCurve
//     TriangleReduction
//     TriangleSet
//     Vector
//     Vector3
//     View
//     World

    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class AdvancedFace
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class AdvancedFace : GeometricItem
    {
        /// <summary>
        /// Create new instace of OWL class AdvancedFace and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new AdvancedFace Create(Int64 model, string name=null) { return new AdvancedFace(Instance.Create(model, "AdvancedFace", name), "AdvancedFace");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public AdvancedFace(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "AdvancedFace") 
        {            
        }

        public static implicit operator AdvancedFace(Int64 instance) => new AdvancedFace(instance);


        //
        // Properties with known cardinality restrictions to AdvancedFace
        //

        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] bounds
            {
            set
                {
                SetObjectProperty("bounds", value);
                }
            get
                {
                var propId = GetPropertyId("bounds");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Curve[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Curve(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..-1</summary>
        public Int64[] bounds_h
        {
            set
                {
                SetObjectProperty("bounds", value);
                }
            get
                {
                var propId = GetPropertyId("bounds");

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
        ///<summary>Access relationship from this instance to an instance of Surface</summary>
        public Surface surface
            {
            set
                {
                SetObjectProperty("surface", value);
                }
            get
                {
                var propId = GetPropertyId("surface");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Surface(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class AdvancedFace2D
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class AdvancedFace2D : AdvancedFace
    {
        /// <summary>
        /// Create new instace of OWL class AdvancedFace2D and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new AdvancedFace2D Create(Int64 model, string name=null) { return new AdvancedFace2D(Instance.Create(model, "AdvancedFace2D", name), "AdvancedFace2D");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public AdvancedFace2D(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "AdvancedFace2D") 
        {            
        }

        public static implicit operator AdvancedFace2D(Int64 instance) => new AdvancedFace2D(instance);


        //
        // Properties with known cardinality restrictions to AdvancedFace2D
        //

        ///<summary>Access value of clipped</summary>
        public bool? clipped
            {
            set { SetDatatypeProperty("clipped", value); }
            get { var arr = GetDatatypeProperty_bool("clipped"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access value of scalingX</summary>
        public double? scalingX
            {
            set { SetDatatypeProperty("scalingX", value); }
            get { var arr = GetDatatypeProperty_double("scalingX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of scalingY</summary>
        public double? scalingY
            {
            set { SetDatatypeProperty("scalingY", value); }
            get { var arr = GetDatatypeProperty_double("scalingY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class AdvancedFace3D
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class AdvancedFace3D : AdvancedFace
    {
        /// <summary>
        /// Create new instace of OWL class AdvancedFace3D and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new AdvancedFace3D Create(Int64 model, string name=null) { return new AdvancedFace3D(Instance.Create(model, "AdvancedFace3D", name), "AdvancedFace3D");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public AdvancedFace3D(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "AdvancedFace3D") 
        {            
        }

        public static implicit operator AdvancedFace3D(Int64 instance) => new AdvancedFace3D(instance);


        //
        // Properties with known cardinality restrictions to AdvancedFace3D
        //

        ///<summary>Access values of isOuterBound. OWL cardinality 0..-1</summary>
        public bool[] isOuterBound
            {
            set { SetDatatypeProperty("isOuterBound", value); }
            get { return GetDatatypeProperty_bool("isOuterBound"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class AdvancedFaceMapped
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class AdvancedFaceMapped : AdvancedFace
    {
        /// <summary>
        /// Create new instace of OWL class AdvancedFaceMapped and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new AdvancedFaceMapped Create(Int64 model, string name=null) { return new AdvancedFaceMapped(Instance.Create(model, "AdvancedFaceMapped", name), "AdvancedFaceMapped");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public AdvancedFaceMapped(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "AdvancedFaceMapped") 
        {            
        }

        public static implicit operator AdvancedFaceMapped(Int64 instance) => new AdvancedFaceMapped(instance);


        //
        // Properties with known cardinality restrictions to AdvancedFaceMapped
        //

        ///<summary>Access value of scalingX</summary>
        public double? scalingX
            {
            set { SetDatatypeProperty("scalingX", value); }
            get { var arr = GetDatatypeProperty_double("scalingX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of scalingY</summary>
        public double? scalingY
            {
            set { SetDatatypeProperty("scalingY", value); }
            get { var arr = GetDatatypeProperty_double("scalingY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class AlignedSegment
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class AlignedSegment : Curve
    {
        /// <summary>
        /// Create new instace of OWL class AlignedSegment and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new AlignedSegment Create(Int64 model, string name=null) { return new AlignedSegment(Instance.Create(model, "AlignedSegment", name), "AlignedSegment");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public AlignedSegment(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "AlignedSegment") 
        {            
        }

        public static implicit operator AlignedSegment(Int64 instance) => new AlignedSegment(instance);


        //
        // Properties with known cardinality restrictions to AlignedSegment
        //

        ///<summary>Access value of length</summary>
        public double? length
            {
            set { SetDatatypeProperty("length", value); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of offsetX</summary>
        public double? offsetX
            {
            set { SetDatatypeProperty("offsetX", value); }
            get { var arr = GetDatatypeProperty_double("offsetX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of offsetY</summary>
        public double? offsetY
            {
            set { SetDatatypeProperty("offsetY", value); }
            get { var arr = GetDatatypeProperty_double("offsetY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve segment
            {
            set
                {
                SetObjectProperty("segment", value);
                }
            get
                {
                var propId = GetPropertyId("segment");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access values of tangentDirectionStart. OWL cardinality 3..3</summary>
        public double[] tangentDirectionStart
            {
            set { SetDatatypeProperty("tangentDirectionStart", value); }
            get { return GetDatatypeProperty_double("tangentDirectionStart"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class AlignedSegments
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class AlignedSegments : Curve
    {
        /// <summary>
        /// Create new instace of OWL class AlignedSegments and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new AlignedSegments Create(Int64 model, string name=null) { return new AlignedSegments(Instance.Create(model, "AlignedSegments", name), "AlignedSegments");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public AlignedSegments(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "AlignedSegments") 
        {            
        }

        public static implicit operator AlignedSegments(Int64 instance) => new AlignedSegments(instance);


        //
        // Properties with known cardinality restrictions to AlignedSegments
        //

        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public AlignedSegment[] segments
            {
            set
                {
                SetObjectProperty("segments", value);
                }
            get
                {
                var propId = GetPropertyId("segments");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new AlignedSegment[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new AlignedSegment(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..-1</summary>
        public Int64[] segments_h
        {
            set
                {
                SetObjectProperty("segments", value);
                }
            get
                {
                var propId = GetPropertyId("segments");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Alignment
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Alignment : Curve
    {
        /// <summary>
        /// Create new instace of OWL class Alignment and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Alignment Create(Int64 model, string name=null) { return new Alignment(Instance.Create(model, "Alignment", name), "Alignment");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Alignment(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Alignment") 
        {            
        }

        public static implicit operator Alignment(Int64 instance) => new Alignment(instance);


        //
        // Properties with known cardinality restrictions to Alignment
        //

        ///<summary>Access relationship from this instance to an instance of AlignedSegments</summary>
        public AlignedSegments horizontal
            {
            set
                {
                SetObjectProperty("horizontal", value);
                }
            get
                {
                var propId = GetPropertyId("horizontal");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new AlignedSegments(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of offsetX</summary>
        public double? offsetX
            {
            set { SetDatatypeProperty("offsetX", value); }
            get { var arr = GetDatatypeProperty_double("offsetX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of type</summary>
        public Int64? type
            {
            set { SetDatatypeProperty("type", value); }
            get { var arr = GetDatatypeProperty_Int64("type"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access relationship from this instance to an instance of AlignedSegments</summary>
        public AlignedSegments vertical
            {
            set
                {
                SetObjectProperty("vertical", value);
                }
            get
                {
                var propId = GetPropertyId("vertical");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new AlignedSegments(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class AmbientLight
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class AmbientLight : Light
    {
        /// <summary>
        /// Create new instace of OWL class AmbientLight and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new AmbientLight Create(Int64 model, string name=null) { return new AmbientLight(Instance.Create(model, "AmbientLight", name), "AmbientLight");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public AmbientLight(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "AmbientLight") 
        {            
        }

        public static implicit operator AmbientLight(Int64 instance) => new AmbientLight(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Appearance
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Appearance : Instance
    {
        /// <summary>
        /// Create new instace of OWL class Appearance and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Appearance Create(Int64 model, string name=null) { return new Appearance(Instance.Create(model, "Appearance", name), "Appearance");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Appearance(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Appearance") 
        {            
        }

        public static implicit operator Appearance(Int64 instance) => new Appearance(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Arc3D
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Arc3D : Curve
    {
        /// <summary>
        /// Create new instace of OWL class Arc3D and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Arc3D Create(Int64 model, string name=null) { return new Arc3D(Instance.Create(model, "Arc3D", name), "Arc3D");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Arc3D(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Arc3D") 
        {            
        }

        public static implicit operator Arc3D(Int64 instance) => new Arc3D(instance);


        //
        // Properties with known cardinality restrictions to Arc3D
        //

        ///<summary>Access value of hasNormals</summary>
        public bool? hasNormals
            {
            set { SetDatatypeProperty("hasNormals", value); }
            get { var arr = GetDatatypeProperty_bool("hasNormals"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { SetDatatypeProperty("radius", value); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of size</summary>
        public double? size
            {
            set { SetDatatypeProperty("size", value); }
            get { var arr = GetDatatypeProperty_double("size"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of start</summary>
        public double? start
            {
            set { SetDatatypeProperty("start", value); }
            get { var arr = GetDatatypeProperty_double("start"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class BezierCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class BezierCurve : SplineCurve
    {
        /// <summary>
        /// Create new instace of OWL class BezierCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new BezierCurve Create(Int64 model, string name=null) { return new BezierCurve(Instance.Create(model, "BezierCurve", name), "BezierCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public BezierCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "BezierCurve") 
        {            
        }

        public static implicit operator BezierCurve(Int64 instance) => new BezierCurve(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class BezierSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class BezierSurface : SplineSurface
    {
        /// <summary>
        /// Create new instace of OWL class BezierSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new BezierSurface Create(Int64 model, string name=null) { return new BezierSurface(Instance.Create(model, "BezierSurface", name), "BezierSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public BezierSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "BezierSurface") 
        {            
        }

        public static implicit operator BezierSurface(Int64 instance) => new BezierSurface(instance);


        //
        // Properties with known cardinality restrictions to BezierSurface
        //

        ///<summary>Access value of setting</summary>
        public Int64? setting
            {
            set { SetDatatypeProperty("setting", value); }
            get { var arr = GetDatatypeProperty_Int64("setting"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class BiQuadraticParabola
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class BiQuadraticParabola : TransitionalCurve
    {
        /// <summary>
        /// Create new instace of OWL class BiQuadraticParabola and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new BiQuadraticParabola Create(Int64 model, string name=null) { return new BiQuadraticParabola(Instance.Create(model, "BiQuadraticParabola", name), "BiQuadraticParabola");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public BiQuadraticParabola(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "BiQuadraticParabola") 
        {            
        }

        public static implicit operator BiQuadraticParabola(Int64 instance) => new BiQuadraticParabola(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Blend
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Blend : Solid
    {
        /// <summary>
        /// Create new instace of OWL class Blend and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Blend Create(Int64 model, string name=null) { return new Blend(Instance.Create(model, "Blend", name), "Blend");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Blend(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Blend") 
        {            
        }

        public static implicit operator Blend(Int64 instance) => new Blend(instance);


        //
        // Properties with known cardinality restrictions to Blend
        //

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve bottomPolygon
            {
            set
                {
                SetObjectProperty("bottomPolygon", value);
                }
            get
                {
                var propId = GetPropertyId("bottomPolygon");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of forceSolid</summary>
        public bool? forceSolid
            {
            set { SetDatatypeProperty("forceSolid", value); }
            get { var arr = GetDatatypeProperty_bool("forceSolid"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { SetDatatypeProperty("fraction", value); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of hasBottom</summary>
        public bool? hasBottom
            {
            set { SetDatatypeProperty("hasBottom", value); }
            get { var arr = GetDatatypeProperty_bool("hasBottom"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access value of hasTop</summary>
        public bool? hasTop
            {
            set { SetDatatypeProperty("hasTop", value); }
            get { var arr = GetDatatypeProperty_bool("hasTop"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { SetDatatypeProperty("height", value); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve topPolygon
            {
            set
                {
                SetObjectProperty("topPolygon", value);
                }
            get
                {
                var propId = GetPropertyId("topPolygon");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class BlossCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class BlossCurve : TransitionalCurve
    {
        /// <summary>
        /// Create new instace of OWL class BlossCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new BlossCurve Create(Int64 model, string name=null) { return new BlossCurve(Instance.Create(model, "BlossCurve", name), "BlossCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public BlossCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "BlossCurve") 
        {            
        }

        public static implicit operator BlossCurve(Int64 instance) => new BlossCurve(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class BooleanOperation
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class BooleanOperation : Solid
    {
        /// <summary>
        /// Create new instace of OWL class BooleanOperation and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new BooleanOperation Create(Int64 model, string name=null) { return new BooleanOperation(Instance.Create(model, "BooleanOperation", name), "BooleanOperation");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public BooleanOperation(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "BooleanOperation") 
        {            
        }

        public static implicit operator BooleanOperation(Int64 instance) => new BooleanOperation(instance);


        //
        // Properties with known cardinality restrictions to BooleanOperation
        //

        ///<summary>Access relationship from this instance to an instance of Deviation</summary>
        public Deviation deviation
            {
            set
                {
                SetObjectProperty("deviation", value);
                }
            get
                {
                var propId = GetPropertyId("deviation");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Deviation(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem firstObject
            {
            set
                {
                SetObjectProperty("firstObject", value);
                }
            get
                {
                var propId = GetPropertyId("firstObject");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new GeometricItem(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem secondObject
            {
            set
                {
                SetObjectProperty("secondObject", value);
                }
            get
                {
                var propId = GetPropertyId("secondObject");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new GeometricItem(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of setting</summary>
        public Int64? setting
            {
            set { SetDatatypeProperty("setting", value); }
            get { var arr = GetDatatypeProperty_Int64("setting"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of type</summary>
        public Int64? type
            {
            set { SetDatatypeProperty("type", value); }
            get { var arr = GetDatatypeProperty_Int64("type"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class BooleanOperation2D
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class BooleanOperation2D : Face
    {
        /// <summary>
        /// Create new instace of OWL class BooleanOperation2D and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new BooleanOperation2D Create(Int64 model, string name=null) { return new BooleanOperation2D(Instance.Create(model, "BooleanOperation2D", name), "BooleanOperation2D");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public BooleanOperation2D(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "BooleanOperation2D") 
        {            
        }

        public static implicit operator BooleanOperation2D(Int64 instance) => new BooleanOperation2D(instance);


        //
        // Properties with known cardinality restrictions to BooleanOperation2D
        //

        ///<summary>Access relationship from this instance to an instance of Deviation</summary>
        public Deviation deviation
            {
            set
                {
                SetObjectProperty("deviation", value);
                }
            get
                {
                var propId = GetPropertyId("deviation");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Deviation(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem firstObject
            {
            set
                {
                SetObjectProperty("firstObject", value);
                }
            get
                {
                var propId = GetPropertyId("firstObject");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new GeometricItem(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem secondObject
            {
            set
                {
                SetObjectProperty("secondObject", value);
                }
            get
                {
                var propId = GetPropertyId("secondObject");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new GeometricItem(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of type</summary>
        public Int64? type
            {
            set { SetDatatypeProperty("type", value); }
            get { var arr = GetDatatypeProperty_Int64("type"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class BoundaryRepresentation
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class BoundaryRepresentation : Solid
    {
        /// <summary>
        /// Create new instace of OWL class BoundaryRepresentation and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new BoundaryRepresentation Create(Int64 model, string name=null) { return new BoundaryRepresentation(Instance.Create(model, "BoundaryRepresentation", name), "BoundaryRepresentation");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public BoundaryRepresentation(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "BoundaryRepresentation") 
        {            
        }

        public static implicit operator BoundaryRepresentation(Int64 instance) => new BoundaryRepresentation(instance);


        //
        // Properties with known cardinality restrictions to BoundaryRepresentation
        //

        ///<summary>Access value of consistencyCheck</summary>
        public Int64? consistencyCheck
            {
            set { SetDatatypeProperty("consistencyCheck", value); }
            get { var arr = GetDatatypeProperty_Int64("consistencyCheck"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of epsilon</summary>
        public double? epsilon
            {
            set { SetDatatypeProperty("epsilon", value); }
            get { var arr = GetDatatypeProperty_double("epsilon"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Face[] faces
            {
            set
                {
                SetObjectProperty("faces", value);
                }
            get
                {
                var propId = GetPropertyId("faces");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Face[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Face(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..-1</summary>
        public Int64[] faces_h
        {
            set
                {
                SetObjectProperty("faces", value);
                }
            get
                {
                var propId = GetPropertyId("faces");

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
        ///<summary>Access values of flags. OWL cardinality 0..-1</summary>
        public Int64[] flags
            {
            set { SetDatatypeProperty("flags", value); }
            get { return GetDatatypeProperty_Int64("flags"); }
            }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { SetDatatypeProperty("fraction", value); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access values of indices. OWL cardinality 0..-1</summary>
        public Int64[] indices
            {
            set { SetDatatypeProperty("indices", value); }
            get { return GetDatatypeProperty_Int64("indices"); }
            }
        ///<summary>Access values of normalCoordinates. OWL cardinality 0..-1</summary>
        public double[] normalCoordinates
            {
            set { SetDatatypeProperty("normalCoordinates", value); }
            get { return GetDatatypeProperty_double("normalCoordinates"); }
            }
        ///<summary>Access values of normalIndices. OWL cardinality 0..-1</summary>
        public Int64[] normalIndices
            {
            set { SetDatatypeProperty("normalIndices", value); }
            get { return GetDatatypeProperty_Int64("normalIndices"); }
            }
        ///<summary>Access value of relativeEpsilon</summary>
        public double? relativeEpsilon
            {
            set { SetDatatypeProperty("relativeEpsilon", value); }
            get { var arr = GetDatatypeProperty_double("relativeEpsilon"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access values of textureCoordinates. OWL cardinality 0..-1</summary>
        public double[] textureCoordinates
            {
            set { SetDatatypeProperty("textureCoordinates", value); }
            get { return GetDatatypeProperty_double("textureCoordinates"); }
            }
        ///<summary>Access values of textureIndices. OWL cardinality 0..-1</summary>
        public Int64[] textureIndices
            {
            set { SetDatatypeProperty("textureIndices", value); }
            get { return GetDatatypeProperty_Int64("textureIndices"); }
            }
        ///<summary>Access value of vertexEpsilon</summary>
        public double? vertexEpsilon
            {
            set { SetDatatypeProperty("vertexEpsilon", value); }
            get { var arr = GetDatatypeProperty_double("vertexEpsilon"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access values of vertices. OWL cardinality 0..-1</summary>
        public double[] vertices
            {
            set { SetDatatypeProperty("vertices", value); }
            get { return GetDatatypeProperty_double("vertices"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Box
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Box : Solid
    {
        /// <summary>
        /// Create new instace of OWL class Box and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Box Create(Int64 model, string name=null) { return new Box(Instance.Create(model, "Box", name), "Box");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Box(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Box") 
        {            
        }

        public static implicit operator Box(Int64 instance) => new Box(instance);


        //
        // Properties with known cardinality restrictions to Box
        //

        ///<summary>Access value of height</summary>
        public double? height
            {
            set { SetDatatypeProperty("height", value); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { SetDatatypeProperty("length", value); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of width</summary>
        public double? width
            {
            set { SetDatatypeProperty("width", value); }
            get { var arr = GetDatatypeProperty_double("width"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class BSplineCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class BSplineCurve : SplineCurve
    {
        /// <summary>
        /// Create new instace of OWL class BSplineCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new BSplineCurve Create(Int64 model, string name=null) { return new BSplineCurve(Instance.Create(model, "BSplineCurve", name), "BSplineCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public BSplineCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "BSplineCurve") 
        {            
        }

        public static implicit operator BSplineCurve(Int64 instance) => new BSplineCurve(instance);


        //
        // Properties with known cardinality restrictions to BSplineCurve
        //

        ///<summary>Access values of knotMultiplicities. OWL cardinality 0..-1</summary>
        public Int64[] knotMultiplicities
            {
            set { SetDatatypeProperty("knotMultiplicities", value); }
            get { return GetDatatypeProperty_Int64("knotMultiplicities"); }
            }
        ///<summary>Access values of knots. OWL cardinality 2..-1</summary>
        public double[] knots
            {
            set { SetDatatypeProperty("knots", value); }
            get { return GetDatatypeProperty_double("knots"); }
            }
        ///<summary>Access value of setting</summary>
        public Int64? setting
            {
            set { SetDatatypeProperty("setting", value); }
            get { var arr = GetDatatypeProperty_Int64("setting"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class BSplineSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class BSplineSurface : SplineSurface
    {
        /// <summary>
        /// Create new instace of OWL class BSplineSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new BSplineSurface Create(Int64 model, string name=null) { return new BSplineSurface(Instance.Create(model, "BSplineSurface", name), "BSplineSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public BSplineSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "BSplineSurface") 
        {            
        }

        public static implicit operator BSplineSurface(Int64 instance) => new BSplineSurface(instance);


        //
        // Properties with known cardinality restrictions to BSplineSurface
        //

        ///<summary>Access value of setting</summary>
        public Int64? setting
            {
            set { SetDatatypeProperty("setting", value); }
            get { var arr = GetDatatypeProperty_Int64("setting"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access values of uKnotMultiplicities. OWL cardinality 0..-1</summary>
        public Int64[] uKnotMultiplicities
            {
            set { SetDatatypeProperty("uKnotMultiplicities", value); }
            get { return GetDatatypeProperty_Int64("uKnotMultiplicities"); }
            }
        ///<summary>Access values of uKnots. OWL cardinality 2..-1</summary>
        public double[] uKnots
            {
            set { SetDatatypeProperty("uKnots", value); }
            get { return GetDatatypeProperty_double("uKnots"); }
            }
        ///<summary>Access values of vKnotMultiplicities. OWL cardinality 0..-1</summary>
        public Int64[] vKnotMultiplicities
            {
            set { SetDatatypeProperty("vKnotMultiplicities", value); }
            get { return GetDatatypeProperty_Int64("vKnotMultiplicities"); }
            }
        ///<summary>Access values of vKnots. OWL cardinality 2..-1</summary>
        public double[] vKnots
            {
            set { SetDatatypeProperty("vKnots", value); }
            get { return GetDatatypeProperty_double("vKnots"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Circle
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Circle : ConicalCurve
    {
        /// <summary>
        /// Create new instace of OWL class Circle and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Circle Create(Int64 model, string name=null) { return new Circle(Instance.Create(model, "Circle", name), "Circle");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Circle(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Circle") 
        {            
        }

        public static implicit operator Circle(Int64 instance) => new Circle(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class CircleByPoints
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class CircleByPoints : Circle
    {
        /// <summary>
        /// Create new instace of OWL class CircleByPoints and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new CircleByPoints Create(Int64 model, string name=null) { return new CircleByPoints(Instance.Create(model, "CircleByPoints", name), "CircleByPoints");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public CircleByPoints(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "CircleByPoints") 
        {            
        }

        public static implicit operator CircleByPoints(Int64 instance) => new CircleByPoints(instance);


        //
        // Properties with known cardinality restrictions to CircleByPoints
        //

        ///<summary>Access an array of related instances. OWL cardinality 3..3</summary>
        public Point[] pointReferences
            {
            set
                {
                SetObjectProperty("pointReferences", value);
                }
            get
                {
                var propId = GetPropertyId("pointReferences");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Point[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Point(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 3..3</summary>
        public Int64[] pointReferences_h
        {
            set
                {
                SetObjectProperty("pointReferences", value);
                }
            get
                {
                var propId = GetPropertyId("pointReferences");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class ClippedPyramid
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class ClippedPyramid : Solid
    {
        /// <summary>
        /// Create new instace of OWL class ClippedPyramid and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new ClippedPyramid Create(Int64 model, string name=null) { return new ClippedPyramid(Instance.Create(model, "ClippedPyramid", name), "ClippedPyramid");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public ClippedPyramid(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "ClippedPyramid") 
        {            
        }

        public static implicit operator ClippedPyramid(Int64 instance) => new ClippedPyramid(instance);


        //
        // Properties with known cardinality restrictions to ClippedPyramid
        //

        ///<summary>Access values of coordinates. OWL cardinality 12..12</summary>
        public double[] coordinates
            {
            set { SetDatatypeProperty("coordinates", value); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        ///<summary>Access values of points. OWL cardinality 0..12</summary>
        public double[] points
            {
            set { SetDatatypeProperty("points", value); }
            get { return GetDatatypeProperty_double("points"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Clipping
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Clipping : Solid
    {
        /// <summary>
        /// Create new instace of OWL class Clipping and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Clipping Create(Int64 model, string name=null) { return new Clipping(Instance.Create(model, "Clipping", name), "Clipping");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Clipping(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Clipping") 
        {            
        }

        public static implicit operator Clipping(Int64 instance) => new Clipping(instance);


        //
        // Properties with known cardinality restrictions to Clipping
        //

        ///<summary>Access relationship from this instance to an instance of Deviation</summary>
        public Deviation deviation
            {
            set
                {
                SetObjectProperty("deviation", value);
                }
            get
                {
                var propId = GetPropertyId("deviation");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Deviation(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                SetObjectProperty("object", value);
                }
            get
                {
                var propId = GetPropertyId("object");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new GeometricItem(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of Plane</summary>
        public Plane plane
            {
            set
                {
                SetObjectProperty("plane", value);
                }
            get
                {
                var propId = GetPropertyId("plane");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Plane(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of type</summary>
        public Int64? type
            {
            set { SetDatatypeProperty("type", value); }
            get { var arr = GetDatatypeProperty_Int64("type"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Clothoid
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Clothoid : Curve
    {
        /// <summary>
        /// Create new instace of OWL class Clothoid and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Clothoid Create(Int64 model, string name=null) { return new Clothoid(Instance.Create(model, "Clothoid", name), "Clothoid");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Clothoid(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Clothoid") 
        {            
        }

        public static implicit operator Clothoid(Int64 instance) => new Clothoid(instance);


        //
        // Properties with known cardinality restrictions to Clothoid
        //

        ///<summary>Access value of A</summary>
        public double? A
            {
            set { SetDatatypeProperty("A", value); }
            get { var arr = GetDatatypeProperty_double("A"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access relationship from this instance to an instance of Vector</summary>
        public Vector direction
            {
            set
                {
                SetObjectProperty("direction", value);
                }
            get
                {
                var propId = GetPropertyId("direction");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Vector(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { SetDatatypeProperty("length", value); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of orientation</summary>
        public Int64? orientation
            {
            set { SetDatatypeProperty("orientation", value); }
            get { var arr = GetDatatypeProperty_Int64("orientation"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { SetDatatypeProperty("radius", value); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class ClothoidCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class ClothoidCurve : TransitionalCurve
    {
        /// <summary>
        /// Create new instace of OWL class ClothoidCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new ClothoidCurve Create(Int64 model, string name=null) { return new ClothoidCurve(Instance.Create(model, "ClothoidCurve", name), "ClothoidCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public ClothoidCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "ClothoidCurve") 
        {            
        }

        public static implicit operator ClothoidCurve(Int64 instance) => new ClothoidCurve(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Collection
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Collection : GeometricItem
    {
        /// <summary>
        /// Create new instace of OWL class Collection and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Collection Create(Int64 model, string name=null) { return new Collection(Instance.Create(model, "Collection", name), "Collection");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Collection(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Collection") 
        {            
        }

        public static implicit operator Collection(Int64 instance) => new Collection(instance);


        //
        // Properties with known cardinality restrictions to Collection
        //

        ///<summary>Access value of consistencyCheck</summary>
        public Int64? consistencyCheck
            {
            set { SetDatatypeProperty("consistencyCheck", value); }
            get { var arr = GetDatatypeProperty_Int64("consistencyCheck"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of epsilon</summary>
        public double? epsilon
            {
            set { SetDatatypeProperty("epsilon", value); }
            get { var arr = GetDatatypeProperty_double("epsilon"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of forceSolid</summary>
        public bool? forceSolid
            {
            set { SetDatatypeProperty("forceSolid", value); }
            get { var arr = GetDatatypeProperty_bool("forceSolid"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { SetDatatypeProperty("fraction", value); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public GeometricItem[] objects
            {
            set
                {
                SetObjectProperty("objects", value);
                }
            get
                {
                var propId = GetPropertyId("objects");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new GeometricItem[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new GeometricItem(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..-1</summary>
        public Int64[] objects_h
        {
            set
                {
                SetObjectProperty("objects", value);
                }
            get
                {
                var propId = GetPropertyId("objects");

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
        ///<summary>Access value of recalculateBBox</summary>
        public bool? recalculateBBox
            {
            set { SetDatatypeProperty("recalculateBBox", value); }
            get { var arr = GetDatatypeProperty_bool("recalculateBBox"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access value of relativeEpsilon</summary>
        public double? relativeEpsilon
            {
            set { SetDatatypeProperty("relativeEpsilon", value); }
            get { var arr = GetDatatypeProperty_double("relativeEpsilon"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of representsSolid</summary>
        public bool? representsSolid
            {
            set { SetDatatypeProperty("representsSolid", value); }
            get { var arr = GetDatatypeProperty_bool("representsSolid"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access value of vertexEpsilon</summary>
        public double? vertexEpsilon
            {
            set { SetDatatypeProperty("vertexEpsilon", value); }
            get { var arr = GetDatatypeProperty_double("vertexEpsilon"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Color
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Color : Appearance
    {
        /// <summary>
        /// Create new instace of OWL class Color and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Color Create(Int64 model, string name=null) { return new Color(Instance.Create(model, "Color", name), "Color");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Color(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Color") 
        {            
        }

        public static implicit operator Color(Int64 instance) => new Color(instance);


        //
        // Properties with known cardinality restrictions to Color
        //

        ///<summary>Access relationship from this instance to an instance of ColorComponent</summary>
        public ColorComponent ambient
            {
            set
                {
                SetObjectProperty("ambient", value);
                }
            get
                {
                var propId = GetPropertyId("ambient");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new ColorComponent(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of ambientReflectance</summary>
        public double? ambientReflectance
            {
            set { SetDatatypeProperty("ambientReflectance", value); }
            get { var arr = GetDatatypeProperty_double("ambientReflectance"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access relationship from this instance to an instance of ColorComponent</summary>
        public ColorComponent diffuse
            {
            set
                {
                SetObjectProperty("diffuse", value);
                }
            get
                {
                var propId = GetPropertyId("diffuse");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new ColorComponent(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of ColorComponent</summary>
        public ColorComponent emissive
            {
            set
                {
                SetObjectProperty("emissive", value);
                }
            get
                {
                var propId = GetPropertyId("emissive");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new ColorComponent(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of ColorComponent</summary>
        public ColorComponent specular
            {
            set
                {
                SetObjectProperty("specular", value);
                }
            get
                {
                var propId = GetPropertyId("specular");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new ColorComponent(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of transparency</summary>
        public double? transparency
            {
            set { SetDatatypeProperty("transparency", value); }
            get { var arr = GetDatatypeProperty_double("transparency"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class ColorComponent
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class ColorComponent : Appearance
    {
        /// <summary>
        /// Create new instace of OWL class ColorComponent and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new ColorComponent Create(Int64 model, string name=null) { return new ColorComponent(Instance.Create(model, "ColorComponent", name), "ColorComponent");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public ColorComponent(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "ColorComponent") 
        {            
        }

        public static implicit operator ColorComponent(Int64 instance) => new ColorComponent(instance);


        //
        // Properties with known cardinality restrictions to ColorComponent
        //

        ///<summary>Access value of B</summary>
        public double? B
            {
            set { SetDatatypeProperty("B", value); }
            get { var arr = GetDatatypeProperty_double("B"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of G</summary>
        public double? G
            {
            set { SetDatatypeProperty("G", value); }
            get { var arr = GetDatatypeProperty_double("G"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of R</summary>
        public double? R
            {
            set { SetDatatypeProperty("R", value); }
            get { var arr = GetDatatypeProperty_double("R"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of W</summary>
        public double? W
            {
            set { SetDatatypeProperty("W", value); }
            get { var arr = GetDatatypeProperty_double("W"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Cone
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Cone : Solid
    {
        /// <summary>
        /// Create new instace of OWL class Cone and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Cone Create(Int64 model, string name=null) { return new Cone(Instance.Create(model, "Cone", name), "Cone");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Cone(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Cone") 
        {            
        }

        public static implicit operator Cone(Int64 instance) => new Cone(instance);


        //
        // Properties with known cardinality restrictions to Cone
        //

        ///<summary>Access value of height</summary>
        public double? height
            {
            set { SetDatatypeProperty("height", value); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { SetDatatypeProperty("radius", value); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class ConicalCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class ConicalCurve : Curve
    {
        /// <summary>
        /// Create new instace of OWL class ConicalCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new ConicalCurve Create(Int64 model, string name=null) { return new ConicalCurve(Instance.Create(model, "ConicalCurve", name), "ConicalCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public ConicalCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "ConicalCurve") 
        {            
        }

        public static implicit operator ConicalCurve(Int64 instance) => new ConicalCurve(instance);


        //
        // Properties with known cardinality restrictions to ConicalCurve
        //

        ///<summary>Access value of a</summary>
        public double? a
            {
            set { SetDatatypeProperty("a", value); }
            get { var arr = GetDatatypeProperty_double("a"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of size</summary>
        public double? size
            {
            set { SetDatatypeProperty("size", value); }
            get { var arr = GetDatatypeProperty_double("size"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of start</summary>
        public double? start
            {
            set { SetDatatypeProperty("start", value); }
            get { var arr = GetDatatypeProperty_double("start"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class ConicalSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class ConicalSurface : InfiniteSurface
    {
        /// <summary>
        /// Create new instace of OWL class ConicalSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new ConicalSurface Create(Int64 model, string name=null) { return new ConicalSurface(Instance.Create(model, "ConicalSurface", name), "ConicalSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public ConicalSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "ConicalSurface") 
        {            
        }

        public static implicit operator ConicalSurface(Int64 instance) => new ConicalSurface(instance);


        //
        // Properties with known cardinality restrictions to ConicalSurface
        //

        ///<summary>Access value of height</summary>
        public double? height
            {
            set { SetDatatypeProperty("height", value); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { SetDatatypeProperty("radius", value); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of semiVerticalAngle</summary>
        public double? semiVerticalAngle
            {
            set { SetDatatypeProperty("semiVerticalAngle", value); }
            get { var arr = GetDatatypeProperty_double("semiVerticalAngle"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class ConvexPolyhedron
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class ConvexPolyhedron : Solid
    {
        /// <summary>
        /// Create new instace of OWL class ConvexPolyhedron and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new ConvexPolyhedron Create(Int64 model, string name=null) { return new ConvexPolyhedron(Instance.Create(model, "ConvexPolyhedron", name), "ConvexPolyhedron");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public ConvexPolyhedron(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "ConvexPolyhedron") 
        {            
        }

        public static implicit operator ConvexPolyhedron(Int64 instance) => new ConvexPolyhedron(instance);


        //
        // Properties with known cardinality restrictions to ConvexPolyhedron
        //

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                SetObjectProperty("object", value);
                }
            get
                {
                var propId = GetPropertyId("object");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new GeometricItem(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Copy
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Copy : GeometricItem
    {
        /// <summary>
        /// Create new instace of OWL class Copy and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Copy Create(Int64 model, string name=null) { return new Copy(Instance.Create(model, "Copy", name), "Copy");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Copy(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Copy") 
        {            
        }

        public static implicit operator Copy(Int64 instance) => new Copy(instance);


        //
        // Properties with known cardinality restrictions to Copy
        //

        ///<summary>Access value of instanceReference</summary>
        public Int64? instanceReference
            {
            set { SetDatatypeProperty("instanceReference", value); }
            get { var arr = GetDatatypeProperty_Int64("instanceReference"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class CosineCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class CosineCurve : TransitionalCurve
    {
        /// <summary>
        /// Create new instace of OWL class CosineCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new CosineCurve Create(Int64 model, string name=null) { return new CosineCurve(Instance.Create(model, "CosineCurve", name), "CosineCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public CosineCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "CosineCurve") 
        {            
        }

        public static implicit operator CosineCurve(Int64 instance) => new CosineCurve(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Cube
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Cube : Solid
    {
        /// <summary>
        /// Create new instace of OWL class Cube and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Cube Create(Int64 model, string name=null) { return new Cube(Instance.Create(model, "Cube", name), "Cube");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Cube(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Cube") 
        {            
        }

        public static implicit operator Cube(Int64 instance) => new Cube(instance);


        //
        // Properties with known cardinality restrictions to Cube
        //

        ///<summary>Access value of length</summary>
        public double? length
            {
            set { SetDatatypeProperty("length", value); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class CubicParabola
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class CubicParabola : TransitionalCurve
    {
        /// <summary>
        /// Create new instace of OWL class CubicParabola and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new CubicParabola Create(Int64 model, string name=null) { return new CubicParabola(Instance.Create(model, "CubicParabola", name), "CubicParabola");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public CubicParabola(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "CubicParabola") 
        {            
        }

        public static implicit operator CubicParabola(Int64 instance) => new CubicParabola(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Cuboid
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Cuboid : Solid
    {
        /// <summary>
        /// Create new instace of OWL class Cuboid and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Cuboid Create(Int64 model, string name=null) { return new Cuboid(Instance.Create(model, "Cuboid", name), "Cuboid");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Cuboid(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Cuboid") 
        {            
        }

        public static implicit operator Cuboid(Int64 instance) => new Cuboid(instance);


        //
        // Properties with known cardinality restrictions to Cuboid
        //

        ///<summary>Access value of height</summary>
        public double? height
            {
            set { SetDatatypeProperty("height", value); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { SetDatatypeProperty("length", value); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of width</summary>
        public double? width
            {
            set { SetDatatypeProperty("width", value); }
            get { var arr = GetDatatypeProperty_double("width"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Curve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Curve : GeometricItem
    {
        /// <summary>
        /// Create new instace of OWL class Curve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Curve Create(Int64 model, string name=null) { return new Curve(Instance.Create(model, "Curve", name), "Curve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Curve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Curve") 
        {            
        }

        public static implicit operator Curve(Int64 instance) => new Curve(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class CurvesFromSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class CurvesFromSurface : Curve
    {
        /// <summary>
        /// Create new instace of OWL class CurvesFromSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new CurvesFromSurface Create(Int64 model, string name=null) { return new CurvesFromSurface(Instance.Create(model, "CurvesFromSurface", name), "CurvesFromSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public CurvesFromSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "CurvesFromSurface") 
        {            
        }

        public static implicit operator CurvesFromSurface(Int64 instance) => new CurvesFromSurface(instance);


        //
        // Properties with known cardinality restrictions to CurvesFromSurface
        //

        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Face[] faces
            {
            set
                {
                SetObjectProperty("faces", value);
                }
            get
                {
                var propId = GetPropertyId("faces");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Face[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Face(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 1..-1</summary>
        public Int64[] faces_h
        {
            set
                {
                SetObjectProperty("faces", value);
                }
            get
                {
                var propId = GetPropertyId("faces");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Cylinder
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Cylinder : Solid
    {
        /// <summary>
        /// Create new instace of OWL class Cylinder and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Cylinder Create(Int64 model, string name=null) { return new Cylinder(Instance.Create(model, "Cylinder", name), "Cylinder");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Cylinder(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Cylinder") 
        {            
        }

        public static implicit operator Cylinder(Int64 instance) => new Cylinder(instance);


        //
        // Properties with known cardinality restrictions to Cylinder
        //

        ///<summary>Access value of length</summary>
        public double? length
            {
            set { SetDatatypeProperty("length", value); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { SetDatatypeProperty("radius", value); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class CylindricalSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class CylindricalSurface : InfiniteSurface
    {
        /// <summary>
        /// Create new instace of OWL class CylindricalSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new CylindricalSurface Create(Int64 model, string name=null) { return new CylindricalSurface(Instance.Create(model, "CylindricalSurface", name), "CylindricalSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public CylindricalSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "CylindricalSurface") 
        {            
        }

        public static implicit operator CylindricalSurface(Int64 instance) => new CylindricalSurface(instance);


        //
        // Properties with known cardinality restrictions to CylindricalSurface
        //

        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { SetDatatypeProperty("radius", value); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class DegenerateToroidalSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class DegenerateToroidalSurface : FiniteSurface
    {
        /// <summary>
        /// Create new instace of OWL class DegenerateToroidalSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new DegenerateToroidalSurface Create(Int64 model, string name=null) { return new DegenerateToroidalSurface(Instance.Create(model, "DegenerateToroidalSurface", name), "DegenerateToroidalSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public DegenerateToroidalSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "DegenerateToroidalSurface") 
        {            
        }

        public static implicit operator DegenerateToroidalSurface(Int64 instance) => new DegenerateToroidalSurface(instance);


        //
        // Properties with known cardinality restrictions to DegenerateToroidalSurface
        //

        ///<summary>Access value of majorRadius</summary>
        public double? majorRadius
            {
            set { SetDatatypeProperty("majorRadius", value); }
            get { var arr = GetDatatypeProperty_double("majorRadius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of minorRadius</summary>
        public double? minorRadius
            {
            set { SetDatatypeProperty("minorRadius", value); }
            get { var arr = GetDatatypeProperty_double("minorRadius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Deviation
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Deviation : Instance
    {
        /// <summary>
        /// Create new instace of OWL class Deviation and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Deviation Create(Int64 model, string name=null) { return new Deviation(Instance.Create(model, "Deviation", name), "Deviation");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Deviation(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Deviation") 
        {            
        }

        public static implicit operator Deviation(Int64 instance) => new Deviation(instance);


        //
        // Properties with known cardinality restrictions to Deviation
        //

        ///<summary>Access value of absoluteEpsilon</summary>
        public double? absoluteEpsilon
            {
            set { SetDatatypeProperty("absoluteEpsilon", value); }
            get { var arr = GetDatatypeProperty_double("absoluteEpsilon"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of relativeEpsilon</summary>
        public double? relativeEpsilon
            {
            set { SetDatatypeProperty("relativeEpsilon", value); }
            get { var arr = GetDatatypeProperty_double("relativeEpsilon"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class DirectionalLight
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class DirectionalLight : DirectLight
    {
        /// <summary>
        /// Create new instace of OWL class DirectionalLight and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new DirectionalLight Create(Int64 model, string name=null) { return new DirectionalLight(Instance.Create(model, "DirectionalLight", name), "DirectionalLight");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public DirectionalLight(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "DirectionalLight") 
        {            
        }

        public static implicit operator DirectionalLight(Int64 instance) => new DirectionalLight(instance);


        //
        // Properties with known cardinality restrictions to DirectionalLight
        //

        ///<summary>Access relationship from this instance to an instance of Vector</summary>
        public Vector direction
            {
            set
                {
                SetObjectProperty("direction", value);
                }
            get
                {
                var propId = GetPropertyId("direction");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Vector(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class DirectLight
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class DirectLight : Light
    {
        /// <summary>
        /// Create new instace of OWL class DirectLight and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new DirectLight Create(Int64 model, string name=null) { return new DirectLight(Instance.Create(model, "DirectLight", name), "DirectLight");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public DirectLight(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "DirectLight") 
        {            
        }

        public static implicit operator DirectLight(Int64 instance) => new DirectLight(instance);


        //
        // Properties with known cardinality restrictions to DirectLight
        //

        ///<summary>Access value of attenuation</summary>
        public double? attenuation
            {
            set { SetDatatypeProperty("attenuation", value); }
            get { var arr = GetDatatypeProperty_double("attenuation"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of range</summary>
        public double? range
            {
            set { SetDatatypeProperty("range", value); }
            get { var arr = GetDatatypeProperty_double("range"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Dummy
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Dummy : GeometricItem
    {
        /// <summary>
        /// Create new instace of OWL class Dummy and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Dummy Create(Int64 model, string name=null) { return new Dummy(Instance.Create(model, "Dummy", name), "Dummy");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Dummy(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Dummy") 
        {            
        }

        public static implicit operator Dummy(Int64 instance) => new Dummy(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Ellipse
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Ellipse : ConicalCurve
    {
        /// <summary>
        /// Create new instace of OWL class Ellipse and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Ellipse Create(Int64 model, string name=null) { return new Ellipse(Instance.Create(model, "Ellipse", name), "Ellipse");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Ellipse(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Ellipse") 
        {            
        }

        public static implicit operator Ellipse(Int64 instance) => new Ellipse(instance);


        //
        // Properties with known cardinality restrictions to Ellipse
        //

        ///<summary>Access value of b</summary>
        public double? b
            {
            set { SetDatatypeProperty("b", value); }
            get { var arr = GetDatatypeProperty_double("b"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of radiusI</summary>
        public double? radiusI
            {
            set { SetDatatypeProperty("radiusI", value); }
            get { var arr = GetDatatypeProperty_double("radiusI"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of radiusII</summary>
        public double? radiusII
            {
            set { SetDatatypeProperty("radiusII", value); }
            get { var arr = GetDatatypeProperty_double("radiusII"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class EllipticCone
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class EllipticCone : Solid
    {
        /// <summary>
        /// Create new instace of OWL class EllipticCone and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new EllipticCone Create(Int64 model, string name=null) { return new EllipticCone(Instance.Create(model, "EllipticCone", name), "EllipticCone");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public EllipticCone(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "EllipticCone") 
        {            
        }

        public static implicit operator EllipticCone(Int64 instance) => new EllipticCone(instance);


        //
        // Properties with known cardinality restrictions to EllipticCone
        //

        ///<summary>Access value of height</summary>
        public double? height
            {
            set { SetDatatypeProperty("height", value); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of radiusI</summary>
        public double? radiusI
            {
            set { SetDatatypeProperty("radiusI", value); }
            get { var arr = GetDatatypeProperty_double("radiusI"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of radiusII</summary>
        public double? radiusII
            {
            set { SetDatatypeProperty("radiusII", value); }
            get { var arr = GetDatatypeProperty_double("radiusII"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Environment
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Environment : Instance
    {
        /// <summary>
        /// Create new instace of OWL class Environment and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Environment Create(Int64 model, string name=null) { return new Environment(Instance.Create(model, "Environment", name), "Environment");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Environment(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Environment") 
        {            
        }

        public static implicit operator Environment(Int64 instance) => new Environment(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class ExtrudedPolygon
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class ExtrudedPolygon : Solid
    {
        /// <summary>
        /// Create new instace of OWL class ExtrudedPolygon and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new ExtrudedPolygon Create(Int64 model, string name=null) { return new ExtrudedPolygon(Instance.Create(model, "ExtrudedPolygon", name), "ExtrudedPolygon");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public ExtrudedPolygon(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "ExtrudedPolygon") 
        {            
        }

        public static implicit operator ExtrudedPolygon(Int64 instance) => new ExtrudedPolygon(instance);


        //
        // Properties with known cardinality restrictions to ExtrudedPolygon
        //

        ///<summary>Access value of extrusionLength</summary>
        public double? extrusionLength
            {
            set { SetDatatypeProperty("extrusionLength", value); }
            get { var arr = GetDatatypeProperty_double("extrusionLength"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { SetDatatypeProperty("fraction", value); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access values of openingPoints. OWL cardinality 0..-1</summary>
        public double[] openingPoints
            {
            set { SetDatatypeProperty("openingPoints", value); }
            get { return GetDatatypeProperty_double("openingPoints"); }
            }
        ///<summary>Access values of openingSizes. OWL cardinality 0..-1</summary>
        public Int64[] openingSizes
            {
            set { SetDatatypeProperty("openingSizes", value); }
            get { return GetDatatypeProperty_Int64("openingSizes"); }
            }
        ///<summary>Access values of points. OWL cardinality 6..-1</summary>
        public double[] points
            {
            set { SetDatatypeProperty("points", value); }
            get { return GetDatatypeProperty_double("points"); }
            }
        ///<summary>Access values of polygonDirection. OWL cardinality 0..3</summary>
        public double[] polygonDirection
            {
            set { SetDatatypeProperty("polygonDirection", value); }
            get { return GetDatatypeProperty_double("polygonDirection"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class ExtrudedPolygonTapered
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class ExtrudedPolygonTapered : Solid
    {
        /// <summary>
        /// Create new instace of OWL class ExtrudedPolygonTapered and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new ExtrudedPolygonTapered Create(Int64 model, string name=null) { return new ExtrudedPolygonTapered(Instance.Create(model, "ExtrudedPolygonTapered", name), "ExtrudedPolygonTapered");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public ExtrudedPolygonTapered(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "ExtrudedPolygonTapered") 
        {            
        }

        public static implicit operator ExtrudedPolygonTapered(Int64 instance) => new ExtrudedPolygonTapered(instance);


        //
        // Properties with known cardinality restrictions to ExtrudedPolygonTapered
        //

        ///<summary>Access value of extrusionLength</summary>
        public double? extrusionLength
            {
            set { SetDatatypeProperty("extrusionLength", value); }
            get { var arr = GetDatatypeProperty_double("extrusionLength"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { SetDatatypeProperty("fraction", value); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access values of openingPoints. OWL cardinality 0..-1</summary>
        public double[] openingPoints
            {
            set { SetDatatypeProperty("openingPoints", value); }
            get { return GetDatatypeProperty_double("openingPoints"); }
            }
        ///<summary>Access values of openingPointsEnd. OWL cardinality 0..-1</summary>
        public double[] openingPointsEnd
            {
            set { SetDatatypeProperty("openingPointsEnd", value); }
            get { return GetDatatypeProperty_double("openingPointsEnd"); }
            }
        ///<summary>Access values of openingSizes. OWL cardinality 0..-1</summary>
        public Int64[] openingSizes
            {
            set { SetDatatypeProperty("openingSizes", value); }
            get { return GetDatatypeProperty_Int64("openingSizes"); }
            }
        ///<summary>Access values of openingSizesEnd. OWL cardinality 0..-1</summary>
        public Int64[] openingSizesEnd
            {
            set { SetDatatypeProperty("openingSizesEnd", value); }
            get { return GetDatatypeProperty_Int64("openingSizesEnd"); }
            }
        ///<summary>Access values of points. OWL cardinality 6..-1</summary>
        public double[] points
            {
            set { SetDatatypeProperty("points", value); }
            get { return GetDatatypeProperty_double("points"); }
            }
        ///<summary>Access values of pointsEnd. OWL cardinality 6..-1</summary>
        public double[] pointsEnd
            {
            set { SetDatatypeProperty("pointsEnd", value); }
            get { return GetDatatypeProperty_double("pointsEnd"); }
            }
        ///<summary>Access values of polygonDirection. OWL cardinality 0..3</summary>
        public double[] polygonDirection
            {
            set { SetDatatypeProperty("polygonDirection", value); }
            get { return GetDatatypeProperty_double("polygonDirection"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class ExtrusionAreaSolid
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class ExtrusionAreaSolid : Solid
    {
        /// <summary>
        /// Create new instace of OWL class ExtrusionAreaSolid and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new ExtrusionAreaSolid Create(Int64 model, string name=null) { return new ExtrusionAreaSolid(Instance.Create(model, "ExtrusionAreaSolid", name), "ExtrusionAreaSolid");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public ExtrusionAreaSolid(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "ExtrusionAreaSolid") 
        {            
        }

        public static implicit operator ExtrusionAreaSolid(Int64 instance) => new ExtrusionAreaSolid(instance);


        //
        // Properties with known cardinality restrictions to ExtrusionAreaSolid
        //

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve extrusionArea
            {
            set
                {
                SetObjectProperty("extrusionArea", value);
                }
            get
                {
                var propId = GetPropertyId("extrusionArea");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] extrusionAreaOpenings
            {
            set
                {
                SetObjectProperty("extrusionAreaOpenings", value);
                }
            get
                {
                var propId = GetPropertyId("extrusionAreaOpenings");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Curve[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Curve(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..-1</summary>
        public Int64[] extrusionAreaOpenings_h
        {
            set
                {
                SetObjectProperty("extrusionAreaOpenings", value);
                }
            get
                {
                var propId = GetPropertyId("extrusionAreaOpenings");

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
        ///<summary>Access values of extrusionDirection. OWL cardinality 0..3</summary>
        public double[] extrusionDirection
            {
            set { SetDatatypeProperty("extrusionDirection", value); }
            get { return GetDatatypeProperty_double("extrusionDirection"); }
            }
        ///<summary>Access value of extrusionLength</summary>
        public double? extrusionLength
            {
            set { SetDatatypeProperty("extrusionLength", value); }
            get { var arr = GetDatatypeProperty_double("extrusionLength"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { SetDatatypeProperty("fraction", value); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class ExtrusionAreaSolidSet
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class ExtrusionAreaSolidSet : Solid
    {
        /// <summary>
        /// Create new instace of OWL class ExtrusionAreaSolidSet and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new ExtrusionAreaSolidSet Create(Int64 model, string name=null) { return new ExtrusionAreaSolidSet(Instance.Create(model, "ExtrusionAreaSolidSet", name), "ExtrusionAreaSolidSet");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public ExtrusionAreaSolidSet(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "ExtrusionAreaSolidSet") 
        {            
        }

        public static implicit operator ExtrusionAreaSolidSet(Int64 instance) => new ExtrusionAreaSolidSet(instance);


        //
        // Properties with known cardinality restrictions to ExtrusionAreaSolidSet
        //

        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Curve[] extrusionAreaSet
            {
            set
                {
                SetObjectProperty("extrusionAreaSet", value);
                }
            get
                {
                var propId = GetPropertyId("extrusionAreaSet");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Curve[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Curve(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 1..-1</summary>
        public Int64[] extrusionAreaSet_h
        {
            set
                {
                SetObjectProperty("extrusionAreaSet", value);
                }
            get
                {
                var propId = GetPropertyId("extrusionAreaSet");

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
        ///<summary>Access values of extrusionDirection. OWL cardinality 0..3</summary>
        public double[] extrusionDirection
            {
            set { SetDatatypeProperty("extrusionDirection", value); }
            get { return GetDatatypeProperty_double("extrusionDirection"); }
            }
        ///<summary>Access value of extrusionLength</summary>
        public double? extrusionLength
            {
            set { SetDatatypeProperty("extrusionLength", value); }
            get { var arr = GetDatatypeProperty_double("extrusionLength"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { SetDatatypeProperty("fraction", value); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Face
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Face : GeometricItem
    {
        /// <summary>
        /// Create new instace of OWL class Face and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Face Create(Int64 model, string name=null) { return new Face(Instance.Create(model, "Face", name), "Face");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Face(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Face") 
        {            
        }

        public static implicit operator Face(Int64 instance) => new Face(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Face2D
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Face2D : Face
    {
        /// <summary>
        /// Create new instace of OWL class Face2D and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Face2D Create(Int64 model, string name=null) { return new Face2D(Instance.Create(model, "Face2D", name), "Face2D");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Face2D(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Face2D") 
        {            
        }

        public static implicit operator Face2D(Int64 instance) => new Face2D(instance);


        //
        // Properties with known cardinality restrictions to Face2D
        //

        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] innerPolygons
            {
            set
                {
                SetObjectProperty("innerPolygons", value);
                }
            get
                {
                var propId = GetPropertyId("innerPolygons");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Curve[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Curve(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..-1</summary>
        public Int64[] innerPolygons_h
        {
            set
                {
                SetObjectProperty("innerPolygons", value);
                }
            get
                {
                var propId = GetPropertyId("innerPolygons");

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
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve outerPolygon
            {
            set
                {
                SetObjectProperty("outerPolygon", value);
                }
            get
                {
                var propId = GetPropertyId("outerPolygon");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of setting</summary>
        public Int64? setting
            {
            set { SetDatatypeProperty("setting", value); }
            get { var arr = GetDatatypeProperty_Int64("setting"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Face2DSet
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Face2DSet : Face
    {
        /// <summary>
        /// Create new instace of OWL class Face2DSet and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Face2DSet Create(Int64 model, string name=null) { return new Face2DSet(Instance.Create(model, "Face2DSet", name), "Face2DSet");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Face2DSet(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Face2DSet") 
        {            
        }

        public static implicit operator Face2DSet(Int64 instance) => new Face2DSet(instance);


        //
        // Properties with known cardinality restrictions to Face2DSet
        //

        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] polygons
            {
            set
                {
                SetObjectProperty("polygons", value);
                }
            get
                {
                var propId = GetPropertyId("polygons");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Curve[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Curve(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..-1</summary>
        public Int64[] polygons_h
        {
            set
                {
                SetObjectProperty("polygons", value);
                }
            get
                {
                var propId = GetPropertyId("polygons");

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
        ///<summary>Access value of setting</summary>
        public Int64? setting
            {
            set { SetDatatypeProperty("setting", value); }
            get { var arr = GetDatatypeProperty_Int64("setting"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class FiniteSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class FiniteSurface : Surface
    {
        /// <summary>
        /// Create new instace of OWL class FiniteSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new FiniteSurface Create(Int64 model, string name=null) { return new FiniteSurface(Instance.Create(model, "FiniteSurface", name), "FiniteSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public FiniteSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "FiniteSurface") 
        {            
        }

        public static implicit operator FiniteSurface(Int64 instance) => new FiniteSurface(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class FrustumCone
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class FrustumCone : Solid
    {
        /// <summary>
        /// Create new instace of OWL class FrustumCone and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new FrustumCone Create(Int64 model, string name=null) { return new FrustumCone(Instance.Create(model, "FrustumCone", name), "FrustumCone");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public FrustumCone(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "FrustumCone") 
        {            
        }

        public static implicit operator FrustumCone(Int64 instance) => new FrustumCone(instance);


        //
        // Properties with known cardinality restrictions to FrustumCone
        //

        ///<summary>Access value of factor</summary>
        public double? factor
            {
            set { SetDatatypeProperty("factor", value); }
            get { var arr = GetDatatypeProperty_double("factor"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { SetDatatypeProperty("height", value); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { SetDatatypeProperty("radius", value); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class GeometricItem
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class GeometricItem : Instance
    {
        /// <summary>
        /// Create new instace of OWL class GeometricItem and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new GeometricItem Create(Int64 model, string name=null) { return new GeometricItem(Instance.Create(model, "GeometricItem", name), "GeometricItem");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public GeometricItem(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "GeometricItem") 
        {            
        }

        public static implicit operator GeometricItem(Int64 instance) => new GeometricItem(instance);


        //
        // Properties with known cardinality restrictions to GeometricItem
        //

        ///<summary>Access relationship from this instance to an instance of Material</summary>
        public Material material
            {
            set
                {
                SetObjectProperty("material", value);
                }
            get
                {
                var propId = GetPropertyId("material");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Material(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class HornTorus
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class HornTorus : Torus
    {
        /// <summary>
        /// Create new instace of OWL class HornTorus and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new HornTorus Create(Int64 model, string name=null) { return new HornTorus(Instance.Create(model, "HornTorus", name), "HornTorus");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public HornTorus(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "HornTorus") 
        {            
        }

        public static implicit operator HornTorus(Int64 instance) => new HornTorus(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Hyperbola
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Hyperbola : ConicalCurve
    {
        /// <summary>
        /// Create new instace of OWL class Hyperbola and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Hyperbola Create(Int64 model, string name=null) { return new Hyperbola(Instance.Create(model, "Hyperbola", name), "Hyperbola");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Hyperbola(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Hyperbola") 
        {            
        }

        public static implicit operator Hyperbola(Int64 instance) => new Hyperbola(instance);


        //
        // Properties with known cardinality restrictions to Hyperbola
        //

        ///<summary>Access value of b</summary>
        public double? b
            {
            set { SetDatatypeProperty("b", value); }
            get { var arr = GetDatatypeProperty_double("b"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class InfiniteSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class InfiniteSurface : Surface
    {
        /// <summary>
        /// Create new instace of OWL class InfiniteSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new InfiniteSurface Create(Int64 model, string name=null) { return new InfiniteSurface(Instance.Create(model, "InfiniteSurface", name), "InfiniteSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public InfiniteSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "InfiniteSurface") 
        {            
        }

        public static implicit operator InfiniteSurface(Int64 instance) => new InfiniteSurface(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Intersection
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Intersection : GeometricItem
    {
        /// <summary>
        /// Create new instace of OWL class Intersection and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Intersection Create(Int64 model, string name=null) { return new Intersection(Instance.Create(model, "Intersection", name), "Intersection");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Intersection(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Intersection") 
        {            
        }

        public static implicit operator Intersection(Int64 instance) => new Intersection(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class IntersectionCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class IntersectionCurve : Intersection
    {
        /// <summary>
        /// Create new instace of OWL class IntersectionCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new IntersectionCurve Create(Int64 model, string name=null) { return new IntersectionCurve(Instance.Create(model, "IntersectionCurve", name), "IntersectionCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public IntersectionCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "IntersectionCurve") 
        {            
        }

        public static implicit operator IntersectionCurve(Int64 instance) => new IntersectionCurve(instance);


        //
        // Properties with known cardinality restrictions to IntersectionCurve
        //

        ///<summary>Access an array of related instances. OWL cardinality 2..2</summary>
        public Surface[] surfaces
            {
            set
                {
                SetObjectProperty("surfaces", value);
                }
            get
                {
                var propId = GetPropertyId("surfaces");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Surface[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Surface(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 2..2</summary>
        public Int64[] surfaces_h
        {
            set
                {
                SetObjectProperty("surfaces", value);
                }
            get
                {
                var propId = GetPropertyId("surfaces");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class IntersectionPoint
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class IntersectionPoint : Intersection
    {
        /// <summary>
        /// Create new instace of OWL class IntersectionPoint and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new IntersectionPoint Create(Int64 model, string name=null) { return new IntersectionPoint(Instance.Create(model, "IntersectionPoint", name), "IntersectionPoint");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public IntersectionPoint(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "IntersectionPoint") 
        {            
        }

        public static implicit operator IntersectionPoint(Int64 instance) => new IntersectionPoint(instance);


        //
        // Properties with known cardinality restrictions to IntersectionPoint
        //

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve curve
            {
            set
                {
                SetObjectProperty("curve", value);
                }
            get
                {
                var propId = GetPropertyId("curve");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of Surface</summary>
        public Surface surface
            {
            set
                {
                SetObjectProperty("surface", value);
                }
            get
                {
                var propId = GetPropertyId("surface");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Surface(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class InverseMatrix
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class InverseMatrix : Matrix
    {
        /// <summary>
        /// Create new instace of OWL class InverseMatrix and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new InverseMatrix Create(Int64 model, string name=null) { return new InverseMatrix(Instance.Create(model, "InverseMatrix", name), "InverseMatrix");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public InverseMatrix(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "InverseMatrix") 
        {            
        }

        public static implicit operator InverseMatrix(Int64 instance) => new InverseMatrix(instance);


        //
        // Properties with known cardinality restrictions to InverseMatrix
        //

        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix matrix
            {
            set
                {
                SetObjectProperty("matrix", value);
                }
            get
                {
                var propId = GetPropertyId("matrix");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Matrix(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class InvertedCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class InvertedCurve : Curve
    {
        /// <summary>
        /// Create new instace of OWL class InvertedCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new InvertedCurve Create(Int64 model, string name=null) { return new InvertedCurve(Instance.Create(model, "InvertedCurve", name), "InvertedCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public InvertedCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "InvertedCurve") 
        {            
        }

        public static implicit operator InvertedCurve(Int64 instance) => new InvertedCurve(instance);


        //
        // Properties with known cardinality restrictions to InvertedCurve
        //

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve curve
            {
            set
                {
                SetObjectProperty("curve", value);
                }
            get
                {
                var propId = GetPropertyId("curve");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class InvertedSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class InvertedSurface : Surface
    {
        /// <summary>
        /// Create new instace of OWL class InvertedSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new InvertedSurface Create(Int64 model, string name=null) { return new InvertedSurface(Instance.Create(model, "InvertedSurface", name), "InvertedSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public InvertedSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "InvertedSurface") 
        {            
        }

        public static implicit operator InvertedSurface(Int64 instance) => new InvertedSurface(instance);


        //
        // Properties with known cardinality restrictions to InvertedSurface
        //

        ///<summary>Access relationship from this instance to an instance of Surface</summary>
        public Surface surface
            {
            set
                {
                SetObjectProperty("surface", value);
                }
            get
                {
                var propId = GetPropertyId("surface");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Surface(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Light
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Light : Environment
    {
        /// <summary>
        /// Create new instace of OWL class Light and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Light Create(Int64 model, string name=null) { return new Light(Instance.Create(model, "Light", name), "Light");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Light(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Light") 
        {            
        }

        public static implicit operator Light(Int64 instance) => new Light(instance);


        //
        // Properties with known cardinality restrictions to Light
        //

        ///<summary>Access relationship from this instance to an instance of Color</summary>
        public Color color
            {
            set
                {
                SetObjectProperty("color", value);
                }
            get
                {
                var propId = GetPropertyId("color");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Color(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Line3D
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Line3D : Curve
    {
        /// <summary>
        /// Create new instace of OWL class Line3D and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Line3D Create(Int64 model, string name=null) { return new Line3D(Instance.Create(model, "Line3D", name), "Line3D");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Line3D(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Line3D") 
        {            
        }

        public static implicit operator Line3D(Int64 instance) => new Line3D(instance);


        //
        // Properties with known cardinality restrictions to Line3D
        //

        ///<summary>Access value of asOpenGL</summary>
        public bool? asOpenGL
            {
            set { SetDatatypeProperty("asOpenGL", value); }
            get { var arr = GetDatatypeProperty_bool("asOpenGL"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access values of points. OWL cardinality 6..6</summary>
        public double[] points
            {
            set { SetDatatypeProperty("points", value); }
            get { return GetDatatypeProperty_double("points"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Line3Dn
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Line3Dn : Curve
    {
        /// <summary>
        /// Create new instace of OWL class Line3Dn and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Line3Dn Create(Int64 model, string name=null) { return new Line3Dn(Instance.Create(model, "Line3Dn", name), "Line3Dn");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Line3Dn(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Line3Dn") 
        {            
        }

        public static implicit operator Line3Dn(Int64 instance) => new Line3Dn(instance);


        //
        // Properties with known cardinality restrictions to Line3Dn
        //

        ///<summary>Access value of asOpenGL</summary>
        public bool? asOpenGL
            {
            set { SetDatatypeProperty("asOpenGL", value); }
            get { var arr = GetDatatypeProperty_bool("asOpenGL"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access values of endDirection. OWL cardinality 0..3</summary>
        public double[] endDirection
            {
            set { SetDatatypeProperty("endDirection", value); }
            get { return GetDatatypeProperty_double("endDirection"); }
            }
        ///<summary>Access values of points. OWL cardinality 0..6</summary>
        public double[] points
            {
            set { SetDatatypeProperty("points", value); }
            get { return GetDatatypeProperty_double("points"); }
            }
        ///<summary>Access values of startDirection. OWL cardinality 0..3</summary>
        public double[] startDirection
            {
            set { SetDatatypeProperty("startDirection", value); }
            get { return GetDatatypeProperty_double("startDirection"); }
            }
        ///<summary>Access value of x0</summary>
        public double? x0
            {
            set { SetDatatypeProperty("x0", value); }
            get { var arr = GetDatatypeProperty_double("x0"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of x1</summary>
        public double? x1
            {
            set { SetDatatypeProperty("x1", value); }
            get { var arr = GetDatatypeProperty_double("x1"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of y0</summary>
        public double? y0
            {
            set { SetDatatypeProperty("y0", value); }
            get { var arr = GetDatatypeProperty_double("y0"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of y1</summary>
        public double? y1
            {
            set { SetDatatypeProperty("y1", value); }
            get { var arr = GetDatatypeProperty_double("y1"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of z0</summary>
        public double? z0
            {
            set { SetDatatypeProperty("z0", value); }
            get { var arr = GetDatatypeProperty_double("z0"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of z1</summary>
        public double? z1
            {
            set { SetDatatypeProperty("z1", value); }
            get { var arr = GetDatatypeProperty_double("z1"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Line3DSet
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Line3DSet : Curve
    {
        /// <summary>
        /// Create new instace of OWL class Line3DSet and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Line3DSet Create(Int64 model, string name=null) { return new Line3DSet(Instance.Create(model, "Line3DSet", name), "Line3DSet");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Line3DSet(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Line3DSet") 
        {            
        }

        public static implicit operator Line3DSet(Int64 instance) => new Line3DSet(instance);


        //
        // Properties with known cardinality restrictions to Line3DSet
        //

        ///<summary>Access value of asOpenGL</summary>
        public bool? asOpenGL
            {
            set { SetDatatypeProperty("asOpenGL", value); }
            get { var arr = GetDatatypeProperty_bool("asOpenGL"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access values of points. OWL cardinality 0..-1</summary>
        public double[] points
            {
            set { SetDatatypeProperty("points", value); }
            get { return GetDatatypeProperty_double("points"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Line4D
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Line4D : Curve
    {
        /// <summary>
        /// Create new instace of OWL class Line4D and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Line4D Create(Int64 model, string name=null) { return new Line4D(Instance.Create(model, "Line4D", name), "Line4D");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Line4D(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Line4D") 
        {            
        }

        public static implicit operator Line4D(Int64 instance) => new Line4D(instance);


        //
        // Properties with known cardinality restrictions to Line4D
        //

        ///<summary>Access relationship from this instance to an instance of Point</summary>
        public Point firstPoint
            {
            set
                {
                SetObjectProperty("firstPoint", value);
                }
            get
                {
                var propId = GetPropertyId("firstPoint");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Point(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of Point</summary>
        public Point secondPoint
            {
            set
                {
                SetObjectProperty("secondPoint", value);
                }
            get
                {
                var propId = GetPropertyId("secondPoint");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Point(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class LineByFace
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class LineByFace : Curve
    {
        /// <summary>
        /// Create new instace of OWL class LineByFace and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new LineByFace Create(Int64 model, string name=null) { return new LineByFace(Instance.Create(model, "LineByFace", name), "LineByFace");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public LineByFace(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "LineByFace") 
        {            
        }

        public static implicit operator LineByFace(Int64 instance) => new LineByFace(instance);


        //
        // Properties with known cardinality restrictions to LineByFace
        //

        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Face[] faces
            {
            set
                {
                SetObjectProperty("faces", value);
                }
            get
                {
                var propId = GetPropertyId("faces");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Face[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Face(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 1..-1</summary>
        public Int64[] faces_h
        {
            set
                {
                SetObjectProperty("faces", value);
                }
            get
                {
                var propId = GetPropertyId("faces");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Material
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Material : Appearance
    {
        /// <summary>
        /// Create new instace of OWL class Material and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Material Create(Int64 model, string name=null) { return new Material(Instance.Create(model, "Material", name), "Material");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Material(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Material") 
        {            
        }

        public static implicit operator Material(Int64 instance) => new Material(instance);


        //
        // Properties with known cardinality restrictions to Material
        //

        ///<summary>Access relationship from this instance to an instance of Color</summary>
        public Color color
            {
            set
                {
                SetObjectProperty("color", value);
                }
            get
                {
                var propId = GetPropertyId("color");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Color(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access an array of related instances. OWL cardinality 0..2</summary>
        public Texture[] textures
            {
            set
                {
                SetObjectProperty("textures", value);
                }
            get
                {
                var propId = GetPropertyId("textures");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Texture[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Texture(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..2</summary>
        public Int64[] textures_h
        {
            set
                {
                SetObjectProperty("textures", value);
                }
            get
                {
                var propId = GetPropertyId("textures");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Mathematics
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Mathematics : Instance
    {
        /// <summary>
        /// Create new instace of OWL class Mathematics and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Mathematics Create(Int64 model, string name=null) { return new Mathematics(Instance.Create(model, "Mathematics", name), "Mathematics");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Mathematics(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Mathematics") 
        {            
        }

        public static implicit operator Mathematics(Int64 instance) => new Mathematics(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Matrix
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Matrix : Mathematics
    {
        /// <summary>
        /// Create new instace of OWL class Matrix and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Matrix Create(Int64 model, string name=null) { return new Matrix(Instance.Create(model, "Matrix", name), "Matrix");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Matrix(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Matrix") 
        {            
        }

        public static implicit operator Matrix(Int64 instance) => new Matrix(instance);


        //
        // Properties with known cardinality restrictions to Matrix
        //

        ///<summary>Access value of _11</summary>
        public double? _11
            {
            set { SetDatatypeProperty("_11", value); }
            get { var arr = GetDatatypeProperty_double("_11"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of _12</summary>
        public double? _12
            {
            set { SetDatatypeProperty("_12", value); }
            get { var arr = GetDatatypeProperty_double("_12"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of _13</summary>
        public double? _13
            {
            set { SetDatatypeProperty("_13", value); }
            get { var arr = GetDatatypeProperty_double("_13"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of _21</summary>
        public double? _21
            {
            set { SetDatatypeProperty("_21", value); }
            get { var arr = GetDatatypeProperty_double("_21"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of _22</summary>
        public double? _22
            {
            set { SetDatatypeProperty("_22", value); }
            get { var arr = GetDatatypeProperty_double("_22"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of _23</summary>
        public double? _23
            {
            set { SetDatatypeProperty("_23", value); }
            get { var arr = GetDatatypeProperty_double("_23"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of _31</summary>
        public double? _31
            {
            set { SetDatatypeProperty("_31", value); }
            get { var arr = GetDatatypeProperty_double("_31"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of _32</summary>
        public double? _32
            {
            set { SetDatatypeProperty("_32", value); }
            get { var arr = GetDatatypeProperty_double("_32"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of _33</summary>
        public double? _33
            {
            set { SetDatatypeProperty("_33", value); }
            get { var arr = GetDatatypeProperty_double("_33"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of _41</summary>
        public double? _41
            {
            set { SetDatatypeProperty("_41", value); }
            get { var arr = GetDatatypeProperty_double("_41"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of _42</summary>
        public double? _42
            {
            set { SetDatatypeProperty("_42", value); }
            get { var arr = GetDatatypeProperty_double("_42"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of _43</summary>
        public double? _43
            {
            set { SetDatatypeProperty("_43", value); }
            get { var arr = GetDatatypeProperty_double("_43"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access values of coordinates. OWL cardinality 0..12</summary>
        public double[] coordinates
            {
            set { SetDatatypeProperty("coordinates", value); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class MatrixMultiplication
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class MatrixMultiplication : Matrix
    {
        /// <summary>
        /// Create new instace of OWL class MatrixMultiplication and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new MatrixMultiplication Create(Int64 model, string name=null) { return new MatrixMultiplication(Instance.Create(model, "MatrixMultiplication", name), "MatrixMultiplication");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public MatrixMultiplication(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "MatrixMultiplication") 
        {            
        }

        public static implicit operator MatrixMultiplication(Int64 instance) => new MatrixMultiplication(instance);


        //
        // Properties with known cardinality restrictions to MatrixMultiplication
        //

        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix firstMatrix
            {
            set
                {
                SetObjectProperty("firstMatrix", value);
                }
            get
                {
                var propId = GetPropertyId("firstMatrix");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Matrix(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix secondMatrix
            {
            set
                {
                SetObjectProperty("secondMatrix", value);
                }
            get
                {
                var propId = GetPropertyId("secondMatrix");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Matrix(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Mesh
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Mesh : Face
    {
        /// <summary>
        /// Create new instace of OWL class Mesh and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Mesh Create(Int64 model, string name=null) { return new Mesh(Instance.Create(model, "Mesh", name), "Mesh");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Mesh(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Mesh") 
        {            
        }

        public static implicit operator Mesh(Int64 instance) => new Mesh(instance);


        //
        // Properties with known cardinality restrictions to Mesh
        //

        ///<summary>Access relationship from this instance to an instance of Point3DSet</summary>
        public Point3DSet pointSet
            {
            set
                {
                SetObjectProperty("pointSet", value);
                }
            get
                {
                var propId = GetPropertyId("pointSet");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Point3DSet(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Nill
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Nill : GeometricItem
    {
        /// <summary>
        /// Create new instace of OWL class Nill and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Nill Create(Int64 model, string name=null) { return new Nill(Instance.Create(model, "Nill", name), "Nill");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Nill(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Nill") 
        {            
        }

        public static implicit operator Nill(Int64 instance) => new Nill(instance);


        //
        // Properties with known cardinality restrictions to Nill
        //

        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public GeometricItem[] objects
            {
            set
                {
                SetObjectProperty("objects", value);
                }
            get
                {
                var propId = GetPropertyId("objects");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new GeometricItem[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new GeometricItem(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..-1</summary>
        public Int64[] objects_h
        {
            set
                {
                SetObjectProperty("objects", value);
                }
            get
                {
                var propId = GetPropertyId("objects");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class NURBSCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class NURBSCurve : BSplineCurve
    {
        /// <summary>
        /// Create new instace of OWL class NURBSCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new NURBSCurve Create(Int64 model, string name=null) { return new NURBSCurve(Instance.Create(model, "NURBSCurve", name), "NURBSCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public NURBSCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "NURBSCurve") 
        {            
        }

        public static implicit operator NURBSCurve(Int64 instance) => new NURBSCurve(instance);


        //
        // Properties with known cardinality restrictions to NURBSCurve
        //

        ///<summary>Access values of weights. OWL cardinality 2..-1</summary>
        public double[] weights
            {
            set { SetDatatypeProperty("weights", value); }
            get { return GetDatatypeProperty_double("weights"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class NURBSSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class NURBSSurface : BSplineSurface
    {
        /// <summary>
        /// Create new instace of OWL class NURBSSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new NURBSSurface Create(Int64 model, string name=null) { return new NURBSSurface(Instance.Create(model, "NURBSSurface", name), "NURBSSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public NURBSSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "NURBSSurface") 
        {            
        }

        public static implicit operator NURBSSurface(Int64 instance) => new NURBSSurface(instance);


        //
        // Properties with known cardinality restrictions to NURBSSurface
        //

        ///<summary>Access values of weights. OWL cardinality 4..-1</summary>
        public double[] weights
            {
            set { SetDatatypeProperty("weights", value); }
            get { return GetDatatypeProperty_double("weights"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Parabola
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Parabola : ConicalCurve
    {
        /// <summary>
        /// Create new instace of OWL class Parabola and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Parabola Create(Int64 model, string name=null) { return new Parabola(Instance.Create(model, "Parabola", name), "Parabola");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Parabola(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Parabola") 
        {            
        }

        public static implicit operator Parabola(Int64 instance) => new Parabola(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Plane
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Plane : Mathematics
    {
        /// <summary>
        /// Create new instace of OWL class Plane and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Plane Create(Int64 model, string name=null) { return new Plane(Instance.Create(model, "Plane", name), "Plane");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Plane(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Plane") 
        {            
        }

        public static implicit operator Plane(Int64 instance) => new Plane(instance);


        //
        // Properties with known cardinality restrictions to Plane
        //

        ///<summary>Access value of A</summary>
        public double? A
            {
            set { SetDatatypeProperty("A", value); }
            get { var arr = GetDatatypeProperty_double("A"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of B</summary>
        public double? B
            {
            set { SetDatatypeProperty("B", value); }
            get { var arr = GetDatatypeProperty_double("B"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of C</summary>
        public double? C
            {
            set { SetDatatypeProperty("C", value); }
            get { var arr = GetDatatypeProperty_double("C"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of D</summary>
        public double? D
            {
            set { SetDatatypeProperty("D", value); }
            get { var arr = GetDatatypeProperty_double("D"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class PlaneSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class PlaneSurface : InfiniteSurface
    {
        /// <summary>
        /// Create new instace of OWL class PlaneSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new PlaneSurface Create(Int64 model, string name=null) { return new PlaneSurface(Instance.Create(model, "PlaneSurface", name), "PlaneSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public PlaneSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "PlaneSurface") 
        {            
        }

        public static implicit operator PlaneSurface(Int64 instance) => new PlaneSurface(instance);


        //
        // Properties with known cardinality restrictions to PlaneSurface
        //

        ///<summary>Access relationship from this instance to an instance of Plane</summary>
        public Plane plane
            {
            set
                {
                SetObjectProperty("plane", value);
                }
            get
                {
                var propId = GetPropertyId("plane");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Plane(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Point
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Point : GeometricItem
    {
        /// <summary>
        /// Create new instace of OWL class Point and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Point Create(Int64 model, string name=null) { return new Point(Instance.Create(model, "Point", name), "Point");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Point(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Point") 
        {            
        }

        public static implicit operator Point(Int64 instance) => new Point(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Point3D
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Point3D : Point
    {
        /// <summary>
        /// Create new instace of OWL class Point3D and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Point3D Create(Int64 model, string name=null) { return new Point3D(Instance.Create(model, "Point3D", name), "Point3D");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Point3D(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Point3D") 
        {            
        }

        public static implicit operator Point3D(Int64 instance) => new Point3D(instance);


        //
        // Properties with known cardinality restrictions to Point3D
        //

        ///<summary>Access value of asOpenGL</summary>
        public bool? asOpenGL
            {
            set { SetDatatypeProperty("asOpenGL", value); }
            get { var arr = GetDatatypeProperty_bool("asOpenGL"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access values of coordinates. OWL cardinality 0..3</summary>
        public double[] coordinates
            {
            set { SetDatatypeProperty("coordinates", value); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        ///<summary>Access values of points. OWL cardinality 0..3</summary>
        public double[] points
            {
            set { SetDatatypeProperty("points", value); }
            get { return GetDatatypeProperty_double("points"); }
            }
        ///<summary>Access value of x</summary>
        public double? x
            {
            set { SetDatatypeProperty("x", value); }
            get { var arr = GetDatatypeProperty_double("x"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of y</summary>
        public double? y
            {
            set { SetDatatypeProperty("y", value); }
            get { var arr = GetDatatypeProperty_double("y"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of z</summary>
        public double? z
            {
            set { SetDatatypeProperty("z", value); }
            get { var arr = GetDatatypeProperty_double("z"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Point3DSet
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Point3DSet : Point
    {
        /// <summary>
        /// Create new instace of OWL class Point3DSet and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Point3DSet Create(Int64 model, string name=null) { return new Point3DSet(Instance.Create(model, "Point3DSet", name), "Point3DSet");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Point3DSet(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Point3DSet") 
        {            
        }

        public static implicit operator Point3DSet(Int64 instance) => new Point3DSet(instance);


        //
        // Properties with known cardinality restrictions to Point3DSet
        //

        ///<summary>Access value of asOpenGL</summary>
        public bool? asOpenGL
            {
            set { SetDatatypeProperty("asOpenGL", value); }
            get { var arr = GetDatatypeProperty_bool("asOpenGL"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access values of coordinates. OWL cardinality 0..-1</summary>
        public double[] coordinates
            {
            set { SetDatatypeProperty("coordinates", value); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        ///<summary>Access values of points. OWL cardinality 0..-1</summary>
        public double[] points
            {
            set { SetDatatypeProperty("points", value); }
            get { return GetDatatypeProperty_double("points"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Point3DSetByGeometricItem
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Point3DSetByGeometricItem : Point3DSet
    {
        /// <summary>
        /// Create new instace of OWL class Point3DSetByGeometricItem and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Point3DSetByGeometricItem Create(Int64 model, string name=null) { return new Point3DSetByGeometricItem(Instance.Create(model, "Point3DSetByGeometricItem", name), "Point3DSetByGeometricItem");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Point3DSetByGeometricItem(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Point3DSetByGeometricItem") 
        {            
        }

        public static implicit operator Point3DSetByGeometricItem(Int64 instance) => new Point3DSetByGeometricItem(instance);


        //
        // Properties with known cardinality restrictions to Point3DSetByGeometricItem
        //

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                SetObjectProperty("object", value);
                }
            get
                {
                var propId = GetPropertyId("object");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new GeometricItem(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Point4D
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Point4D : Point
    {
        /// <summary>
        /// Create new instace of OWL class Point4D and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Point4D Create(Int64 model, string name=null) { return new Point4D(Instance.Create(model, "Point4D", name), "Point4D");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Point4D(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Point4D") 
        {            
        }

        public static implicit operator Point4D(Int64 instance) => new Point4D(instance);


        //
        // Properties with known cardinality restrictions to Point4D
        //

        ///<summary>Access relationship from this instance to an instance of Vector3</summary>
        public Vector3 normal
            {
            set
                {
                SetObjectProperty("normal", value);
                }
            get
                {
                var propId = GetPropertyId("normal");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Vector3(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of Point</summary>
        public Point point
            {
            set
                {
                SetObjectProperty("point", value);
                }
            get
                {
                var propId = GetPropertyId("point");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Point(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of Vector3</summary>
        public Vector3 tangent
            {
            set
                {
                SetObjectProperty("tangent", value);
                }
            get
                {
                var propId = GetPropertyId("tangent");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Vector3(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class PointLight
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class PointLight : DirectLight
    {
        /// <summary>
        /// Create new instace of OWL class PointLight and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new PointLight Create(Int64 model, string name=null) { return new PointLight(Instance.Create(model, "PointLight", name), "PointLight");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public PointLight(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "PointLight") 
        {            
        }

        public static implicit operator PointLight(Int64 instance) => new PointLight(instance);


        //
        // Properties with known cardinality restrictions to PointLight
        //

        ///<summary>Access relationship from this instance to an instance of Point3D</summary>
        public Point3D position
            {
            set
                {
                SetObjectProperty("position", value);
                }
            get
                {
                var propId = GetPropertyId("position");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Point3D(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class PointLoop
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class PointLoop : Curve
    {
        /// <summary>
        /// Create new instace of OWL class PointLoop and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new PointLoop Create(Int64 model, string name=null) { return new PointLoop(Instance.Create(model, "PointLoop", name), "PointLoop");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public PointLoop(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "PointLoop") 
        {            
        }

        public static implicit operator PointLoop(Int64 instance) => new PointLoop(instance);


        //
        // Properties with known cardinality restrictions to PointLoop
        //

        ///<summary>Access values of coordinates. OWL cardinality 0..3</summary>
        public double[] coordinates
            {
            set { SetDatatypeProperty("coordinates", value); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        ///<summary>Access value of x</summary>
        public double? x
            {
            set { SetDatatypeProperty("x", value); }
            get { var arr = GetDatatypeProperty_double("x"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of y</summary>
        public double? y
            {
            set { SetDatatypeProperty("y", value); }
            get { var arr = GetDatatypeProperty_double("y"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of z</summary>
        public double? z
            {
            set { SetDatatypeProperty("z", value); }
            get { var arr = GetDatatypeProperty_double("z"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Polygon2D
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Polygon2D : Curve
    {
        /// <summary>
        /// Create new instace of OWL class Polygon2D and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Polygon2D Create(Int64 model, string name=null) { return new Polygon2D(Instance.Create(model, "Polygon2D", name), "Polygon2D");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Polygon2D(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Polygon2D") 
        {            
        }

        public static implicit operator Polygon2D(Int64 instance) => new Polygon2D(instance);


        //
        // Properties with known cardinality restrictions to Polygon2D
        //

        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Curve[] lineParts
            {
            set
                {
                SetObjectProperty("lineParts", value);
                }
            get
                {
                var propId = GetPropertyId("lineParts");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Curve[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Curve(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 1..-1</summary>
        public Int64[] lineParts_h
        {
            set
                {
                SetObjectProperty("lineParts", value);
                }
            get
                {
                var propId = GetPropertyId("lineParts");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Polygon3D
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Polygon3D : Curve
    {
        /// <summary>
        /// Create new instace of OWL class Polygon3D and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Polygon3D Create(Int64 model, string name=null) { return new Polygon3D(Instance.Create(model, "Polygon3D", name), "Polygon3D");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Polygon3D(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Polygon3D") 
        {            
        }

        public static implicit operator Polygon3D(Int64 instance) => new Polygon3D(instance);


        //
        // Properties with known cardinality restrictions to Polygon3D
        //

        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Curve[] lineParts
            {
            set
                {
                SetObjectProperty("lineParts", value);
                }
            get
                {
                var propId = GetPropertyId("lineParts");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Curve[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Curve(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 1..-1</summary>
        public Int64[] lineParts_h
        {
            set
                {
                SetObjectProperty("lineParts", value);
                }
            get
                {
                var propId = GetPropertyId("lineParts");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Polygon4D
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Polygon4D : Curve
    {
        /// <summary>
        /// Create new instace of OWL class Polygon4D and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Polygon4D Create(Int64 model, string name=null) { return new Polygon4D(Instance.Create(model, "Polygon4D", name), "Polygon4D");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Polygon4D(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Polygon4D") 
        {            
        }

        public static implicit operator Polygon4D(Int64 instance) => new Polygon4D(instance);


        //
        // Properties with known cardinality restrictions to Polygon4D
        //

        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Curve[] lineParts
            {
            set
                {
                SetObjectProperty("lineParts", value);
                }
            get
                {
                var propId = GetPropertyId("lineParts");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Curve[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Curve(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 1..-1</summary>
        public Int64[] lineParts_h
        {
            set
                {
                SetObjectProperty("lineParts", value);
                }
            get
                {
                var propId = GetPropertyId("lineParts");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class PolyLine3D
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class PolyLine3D : Curve
    {
        /// <summary>
        /// Create new instace of OWL class PolyLine3D and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new PolyLine3D Create(Int64 model, string name=null) { return new PolyLine3D(Instance.Create(model, "PolyLine3D", name), "PolyLine3D");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public PolyLine3D(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "PolyLine3D") 
        {            
        }

        public static implicit operator PolyLine3D(Int64 instance) => new PolyLine3D(instance);


        //
        // Properties with known cardinality restrictions to PolyLine3D
        //

        ///<summary>Access values of coordinates. OWL cardinality 0..-1</summary>
        public double[] coordinates
            {
            set { SetDatatypeProperty("coordinates", value); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Point[] pointReferences
            {
            set
                {
                SetObjectProperty("pointReferences", value);
                }
            get
                {
                var propId = GetPropertyId("pointReferences");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Point[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Point(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..-1</summary>
        public Int64[] pointReferences_h
        {
            set
                {
                SetObjectProperty("pointReferences", value);
                }
            get
                {
                var propId = GetPropertyId("pointReferences");

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
        ///<summary>Access values of points. OWL cardinality 0..-1</summary>
        public double[] points
            {
            set { SetDatatypeProperty("points", value); }
            get { return GetDatatypeProperty_double("points"); }
            }
        ///<summary>Access values of tangentArray. OWL cardinality 0..-1</summary>
        public double[] tangentArray
            {
            set { SetDatatypeProperty("tangentArray", value); }
            get { return GetDatatypeProperty_double("tangentArray"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Prism
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Prism : Solid
    {
        /// <summary>
        /// Create new instace of OWL class Prism and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Prism Create(Int64 model, string name=null) { return new Prism(Instance.Create(model, "Prism", name), "Prism");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Prism(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Prism") 
        {            
        }

        public static implicit operator Prism(Int64 instance) => new Prism(instance);


        //
        // Properties with known cardinality restrictions to Prism
        //

        ///<summary>Access value of height</summary>
        public double? height
            {
            set { SetDatatypeProperty("height", value); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { SetDatatypeProperty("length", value); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Profile
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Profile : Curve
    {
        /// <summary>
        /// Create new instace of OWL class Profile and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Profile Create(Int64 model, string name=null) { return new Profile(Instance.Create(model, "Profile", name), "Profile");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Profile(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Profile") 
        {            
        }

        public static implicit operator Profile(Int64 instance) => new Profile(instance);


        //
        // Properties with known cardinality restrictions to Profile
        //

        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] innerPolygons
            {
            set
                {
                SetObjectProperty("innerPolygons", value);
                }
            get
                {
                var propId = GetPropertyId("innerPolygons");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Curve[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Curve(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..-1</summary>
        public Int64[] innerPolygons_h
        {
            set
                {
                SetObjectProperty("innerPolygons", value);
                }
            get
                {
                var propId = GetPropertyId("innerPolygons");

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
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve outerPolygon
            {
            set
                {
                SetObjectProperty("outerPolygon", value);
                }
            get
                {
                var propId = GetPropertyId("outerPolygon");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Projection
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Projection : Environment
    {
        /// <summary>
        /// Create new instace of OWL class Projection and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Projection Create(Int64 model, string name=null) { return new Projection(Instance.Create(model, "Projection", name), "Projection");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Projection(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Projection") 
        {            
        }

        public static implicit operator Projection(Int64 instance) => new Projection(instance);


        //
        // Properties with known cardinality restrictions to Projection
        //

        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix matrix
            {
            set
                {
                SetObjectProperty("matrix", value);
                }
            get
                {
                var propId = GetPropertyId("matrix");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Matrix(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Pyramid
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Pyramid : Solid
    {
        /// <summary>
        /// Create new instace of OWL class Pyramid and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Pyramid Create(Int64 model, string name=null) { return new Pyramid(Instance.Create(model, "Pyramid", name), "Pyramid");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Pyramid(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Pyramid") 
        {            
        }

        public static implicit operator Pyramid(Int64 instance) => new Pyramid(instance);


        //
        // Properties with known cardinality restrictions to Pyramid
        //

        ///<summary>Access value of height</summary>
        public double? height
            {
            set { SetDatatypeProperty("height", value); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { SetDatatypeProperty("length", value); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of width</summary>
        public double? width
            {
            set { SetDatatypeProperty("width", value); }
            get { var arr = GetDatatypeProperty_double("width"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class RationalBezierCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class RationalBezierCurve : BezierCurve
    {
        /// <summary>
        /// Create new instace of OWL class RationalBezierCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new RationalBezierCurve Create(Int64 model, string name=null) { return new RationalBezierCurve(Instance.Create(model, "RationalBezierCurve", name), "RationalBezierCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public RationalBezierCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "RationalBezierCurve") 
        {            
        }

        public static implicit operator RationalBezierCurve(Int64 instance) => new RationalBezierCurve(instance);


        //
        // Properties with known cardinality restrictions to RationalBezierCurve
        //

        ///<summary>Access values of weights. OWL cardinality 2..-1</summary>
        public double[] weights
            {
            set { SetDatatypeProperty("weights", value); }
            get { return GetDatatypeProperty_double("weights"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class RationalBezierSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class RationalBezierSurface : BezierSurface
    {
        /// <summary>
        /// Create new instace of OWL class RationalBezierSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new RationalBezierSurface Create(Int64 model, string name=null) { return new RationalBezierSurface(Instance.Create(model, "RationalBezierSurface", name), "RationalBezierSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public RationalBezierSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "RationalBezierSurface") 
        {            
        }

        public static implicit operator RationalBezierSurface(Int64 instance) => new RationalBezierSurface(instance);


        //
        // Properties with known cardinality restrictions to RationalBezierSurface
        //

        ///<summary>Access values of weights. OWL cardinality 4..-1</summary>
        public double[] weights
            {
            set { SetDatatypeProperty("weights", value); }
            get { return GetDatatypeProperty_double("weights"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class RectangleCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class RectangleCurve : Curve
    {
        /// <summary>
        /// Create new instace of OWL class RectangleCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new RectangleCurve Create(Int64 model, string name=null) { return new RectangleCurve(Instance.Create(model, "RectangleCurve", name), "RectangleCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public RectangleCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "RectangleCurve") 
        {            
        }

        public static implicit operator RectangleCurve(Int64 instance) => new RectangleCurve(instance);


        //
        // Properties with known cardinality restrictions to RectangleCurve
        //

        ///<summary>Access value of height</summary>
        public double? height
            {
            set { SetDatatypeProperty("height", value); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of offsetX</summary>
        public double? offsetX
            {
            set { SetDatatypeProperty("offsetX", value); }
            get { var arr = GetDatatypeProperty_double("offsetX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of offsetY</summary>
        public double? offsetY
            {
            set { SetDatatypeProperty("offsetY", value); }
            get { var arr = GetDatatypeProperty_double("offsetY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of offsetZ</summary>
        public double? offsetZ
            {
            set { SetDatatypeProperty("offsetZ", value); }
            get { var arr = GetDatatypeProperty_double("offsetZ"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of width</summary>
        public double? width
            {
            set { SetDatatypeProperty("width", value); }
            get { var arr = GetDatatypeProperty_double("width"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Repetition
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Repetition : GeometricItem
    {
        /// <summary>
        /// Create new instace of OWL class Repetition and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Repetition Create(Int64 model, string name=null) { return new Repetition(Instance.Create(model, "Repetition", name), "Repetition");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Repetition(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Repetition") 
        {            
        }

        public static implicit operator Repetition(Int64 instance) => new Repetition(instance);


        //
        // Properties with known cardinality restrictions to Repetition
        //

        ///<summary>Access value of count</summary>
        public Int64? count
            {
            set { SetDatatypeProperty("count", value); }
            get { var arr = GetDatatypeProperty_Int64("count"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix matrix
            {
            set
                {
                SetObjectProperty("matrix", value);
                }
            get
                {
                var propId = GetPropertyId("matrix");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Matrix(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                SetObjectProperty("object", value);
                }
            get
                {
                var propId = GetPropertyId("object");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new GeometricItem(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class RingTorus
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class RingTorus : Torus
    {
        /// <summary>
        /// Create new instace of OWL class RingTorus and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new RingTorus Create(Int64 model, string name=null) { return new RingTorus(Instance.Create(model, "RingTorus", name), "RingTorus");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public RingTorus(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "RingTorus") 
        {            
        }

        public static implicit operator RingTorus(Int64 instance) => new RingTorus(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Shadow
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Shadow : Face
    {
        /// <summary>
        /// Create new instace of OWL class Shadow and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Shadow Create(Int64 model, string name=null) { return new Shadow(Instance.Create(model, "Shadow", name), "Shadow");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Shadow(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Shadow") 
        {            
        }

        public static implicit operator Shadow(Int64 instance) => new Shadow(instance);


        //
        // Properties with known cardinality restrictions to Shadow
        //

        ///<summary>Access relationship from this instance to an instance of Vector3</summary>
        public Vector3 lightDirection
            {
            set
                {
                SetObjectProperty("lightDirection", value);
                }
            get
                {
                var propId = GetPropertyId("lightDirection");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Vector3(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of Point3D</summary>
        public Point3D lightPoint
            {
            set
                {
                SetObjectProperty("lightPoint", value);
                }
            get
                {
                var propId = GetPropertyId("lightPoint");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Point3D(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                SetObjectProperty("object", value);
                }
            get
                {
                var propId = GetPropertyId("object");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new GeometricItem(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of Plane</summary>
        public Plane plane
            {
            set
                {
                SetObjectProperty("plane", value);
                }
            get
                {
                var propId = GetPropertyId("plane");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Plane(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of Vector3</summary>
        public Vector3 planeRefDirection
            {
            set
                {
                SetObjectProperty("planeRefDirection", value);
                }
            get
                {
                var propId = GetPropertyId("planeRefDirection");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Vector3(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of type</summary>
        public Int64? type
            {
            set { SetDatatypeProperty("type", value); }
            get { var arr = GetDatatypeProperty_Int64("type"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SineCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SineCurve : TransitionalCurve
    {
        /// <summary>
        /// Create new instace of OWL class SineCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SineCurve Create(Int64 model, string name=null) { return new SineCurve(Instance.Create(model, "SineCurve", name), "SineCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SineCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SineCurve") 
        {            
        }

        public static implicit operator SineCurve(Int64 instance) => new SineCurve(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SkewedCone
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SkewedCone : Solid
    {
        /// <summary>
        /// Create new instace of OWL class SkewedCone and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SkewedCone Create(Int64 model, string name=null) { return new SkewedCone(Instance.Create(model, "SkewedCone", name), "SkewedCone");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SkewedCone(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SkewedCone") 
        {            
        }

        public static implicit operator SkewedCone(Int64 instance) => new SkewedCone(instance);


        //
        // Properties with known cardinality restrictions to SkewedCone
        //

        ///<summary>Access value of height</summary>
        public double? height
            {
            set { SetDatatypeProperty("height", value); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of offsetX</summary>
        public double? offsetX
            {
            set { SetDatatypeProperty("offsetX", value); }
            get { var arr = GetDatatypeProperty_double("offsetX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of offsetY</summary>
        public double? offsetY
            {
            set { SetDatatypeProperty("offsetY", value); }
            get { var arr = GetDatatypeProperty_double("offsetY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { SetDatatypeProperty("radius", value); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SkewedFrustumCone
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SkewedFrustumCone : Solid
    {
        /// <summary>
        /// Create new instace of OWL class SkewedFrustumCone and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SkewedFrustumCone Create(Int64 model, string name=null) { return new SkewedFrustumCone(Instance.Create(model, "SkewedFrustumCone", name), "SkewedFrustumCone");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SkewedFrustumCone(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SkewedFrustumCone") 
        {            
        }

        public static implicit operator SkewedFrustumCone(Int64 instance) => new SkewedFrustumCone(instance);


        //
        // Properties with known cardinality restrictions to SkewedFrustumCone
        //

        ///<summary>Access value of factor</summary>
        public double? factor
            {
            set { SetDatatypeProperty("factor", value); }
            get { var arr = GetDatatypeProperty_double("factor"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { SetDatatypeProperty("height", value); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of offsetX</summary>
        public double? offsetX
            {
            set { SetDatatypeProperty("offsetX", value); }
            get { var arr = GetDatatypeProperty_double("offsetX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of offsetY</summary>
        public double? offsetY
            {
            set { SetDatatypeProperty("offsetY", value); }
            get { var arr = GetDatatypeProperty_double("offsetY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { SetDatatypeProperty("radius", value); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Solid
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Solid : GeometricItem
    {
        /// <summary>
        /// Create new instace of OWL class Solid and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Solid Create(Int64 model, string name=null) { return new Solid(Instance.Create(model, "Solid", name), "Solid");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Solid(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Solid") 
        {            
        }

        public static implicit operator Solid(Int64 instance) => new Solid(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SolidBySurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SolidBySurface : Solid
    {
        /// <summary>
        /// Create new instace of OWL class SolidBySurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SolidBySurface Create(Int64 model, string name=null) { return new SolidBySurface(Instance.Create(model, "SolidBySurface", name), "SolidBySurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SolidBySurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SolidBySurface") 
        {            
        }

        public static implicit operator SolidBySurface(Int64 instance) => new SolidBySurface(instance);


        //
        // Properties with known cardinality restrictions to SolidBySurface
        //

        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Face[] faces
            {
            set
                {
                SetObjectProperty("faces", value);
                }
            get
                {
                var propId = GetPropertyId("faces");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Face[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Face(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 1..-1</summary>
        public Int64[] faces_h
        {
            set
                {
                SetObjectProperty("faces", value);
                }
            get
                {
                var propId = GetPropertyId("faces");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SolidLine
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SolidLine : Solid
    {
        /// <summary>
        /// Create new instace of OWL class SolidLine and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SolidLine Create(Int64 model, string name=null) { return new SolidLine(Instance.Create(model, "SolidLine", name), "SolidLine");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SolidLine(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SolidLine") 
        {            
        }

        public static implicit operator SolidLine(Int64 instance) => new SolidLine(instance);


        //
        // Properties with known cardinality restrictions to SolidLine
        //

        ///<summary>Access values of coordinates. OWL cardinality 0..6</summary>
        public double[] coordinates
            {
            set { SetDatatypeProperty("coordinates", value); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of thickness</summary>
        public double? thickness
            {
            set { SetDatatypeProperty("thickness", value); }
            get { var arr = GetDatatypeProperty_double("thickness"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Sphere
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Sphere : Solid
    {
        /// <summary>
        /// Create new instace of OWL class Sphere and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Sphere Create(Int64 model, string name=null) { return new Sphere(Instance.Create(model, "Sphere", name), "Sphere");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Sphere(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Sphere") 
        {            
        }

        public static implicit operator Sphere(Int64 instance) => new Sphere(instance);


        //
        // Properties with known cardinality restrictions to Sphere
        //

        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { SetDatatypeProperty("radius", value); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SphericalSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SphericalSurface : FiniteSurface
    {
        /// <summary>
        /// Create new instace of OWL class SphericalSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SphericalSurface Create(Int64 model, string name=null) { return new SphericalSurface(Instance.Create(model, "SphericalSurface", name), "SphericalSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SphericalSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SphericalSurface") 
        {            
        }

        public static implicit operator SphericalSurface(Int64 instance) => new SphericalSurface(instance);


        //
        // Properties with known cardinality restrictions to SphericalSurface
        //

        ///<summary>Access value of invert</summary>
        public bool? invert
            {
            set { SetDatatypeProperty("invert", value); }
            get { var arr = GetDatatypeProperty_bool("invert"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { SetDatatypeProperty("radius", value); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SpindleTorus
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SpindleTorus : Torus
    {
        /// <summary>
        /// Create new instace of OWL class SpindleTorus and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SpindleTorus Create(Int64 model, string name=null) { return new SpindleTorus(Instance.Create(model, "SpindleTorus", name), "SpindleTorus");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SpindleTorus(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SpindleTorus") 
        {            
        }

        public static implicit operator SpindleTorus(Int64 instance) => new SpindleTorus(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Spiral
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Spiral : Curve
    {
        /// <summary>
        /// Create new instace of OWL class Spiral and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Spiral Create(Int64 model, string name=null) { return new Spiral(Instance.Create(model, "Spiral", name), "Spiral");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Spiral(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Spiral") 
        {            
        }

        public static implicit operator Spiral(Int64 instance) => new Spiral(instance);


        //
        // Properties with known cardinality restrictions to Spiral
        //

        ///<summary>Access value of height</summary>
        public double? height
            {
            set { SetDatatypeProperty("height", value); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of offsetZ</summary>
        public double? offsetZ
            {
            set { SetDatatypeProperty("offsetZ", value); }
            get { var arr = GetDatatypeProperty_double("offsetZ"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { SetDatatypeProperty("radius", value); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of size</summary>
        public double? size
            {
            set { SetDatatypeProperty("size", value); }
            get { var arr = GetDatatypeProperty_double("size"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of start</summary>
        public double? start
            {
            set { SetDatatypeProperty("start", value); }
            get { var arr = GetDatatypeProperty_double("start"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SplineCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SplineCurve : Curve
    {
        /// <summary>
        /// Create new instace of OWL class SplineCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SplineCurve Create(Int64 model, string name=null) { return new SplineCurve(Instance.Create(model, "SplineCurve", name), "SplineCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SplineCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SplineCurve") 
        {            
        }

        public static implicit operator SplineCurve(Int64 instance) => new SplineCurve(instance);


        //
        // Properties with known cardinality restrictions to SplineCurve
        //

        ///<summary>Access value of closed</summary>
        public bool? closed
            {
            set { SetDatatypeProperty("closed", value); }
            get { var arr = GetDatatypeProperty_bool("closed"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access an array of related instances. OWL cardinality 2..-1</summary>
        public Point3D[] controlPoints
            {
            set
                {
                SetObjectProperty("controlPoints", value);
                }
            get
                {
                var propId = GetPropertyId("controlPoints");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Point3D[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Point3D(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 2..-1</summary>
        public Int64[] controlPoints_h
        {
            set
                {
                SetObjectProperty("controlPoints", value);
                }
            get
                {
                var propId = GetPropertyId("controlPoints");

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
        ///<summary>Access value of count</summary>
        public Int64? count
            {
            set { SetDatatypeProperty("count", value); }
            get { var arr = GetDatatypeProperty_Int64("count"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of degree</summary>
        public Int64? degree
            {
            set { SetDatatypeProperty("degree", value); }
            get { var arr = GetDatatypeProperty_Int64("degree"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationLength</summary>
        public double? segmentationLength
            {
            set { SetDatatypeProperty("segmentationLength", value); }
            get { var arr = GetDatatypeProperty_double("segmentationLength"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SplineSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SplineSurface : FiniteSurface
    {
        /// <summary>
        /// Create new instace of OWL class SplineSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SplineSurface Create(Int64 model, string name=null) { return new SplineSurface(Instance.Create(model, "SplineSurface", name), "SplineSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SplineSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SplineSurface") 
        {            
        }

        public static implicit operator SplineSurface(Int64 instance) => new SplineSurface(instance);


        //
        // Properties with known cardinality restrictions to SplineSurface
        //

        ///<summary>Access an array of related instances. OWL cardinality 4..-1</summary>
        public Point3D[] controlPoints
            {
            set
                {
                SetObjectProperty("controlPoints", value);
                }
            get
                {
                var propId = GetPropertyId("controlPoints");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Point3D[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Point3D(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 4..-1</summary>
        public Int64[] controlPoints_h
        {
            set
                {
                SetObjectProperty("controlPoints", value);
                }
            get
                {
                var propId = GetPropertyId("controlPoints");

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
        ///<summary>Access value of segmentationLength</summary>
        public double? segmentationLength
            {
            set { SetDatatypeProperty("segmentationLength", value); }
            get { var arr = GetDatatypeProperty_double("segmentationLength"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of uClosed</summary>
        public bool? uClosed
            {
            set { SetDatatypeProperty("uClosed", value); }
            get { var arr = GetDatatypeProperty_bool("uClosed"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access value of uCount</summary>
        public Int64? uCount
            {
            set { SetDatatypeProperty("uCount", value); }
            get { var arr = GetDatatypeProperty_Int64("uCount"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of uDegree</summary>
        public Int64? uDegree
            {
            set { SetDatatypeProperty("uDegree", value); }
            get { var arr = GetDatatypeProperty_Int64("uDegree"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of uSegmentationParts</summary>
        public Int64? uSegmentationParts
            {
            set { SetDatatypeProperty("uSegmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("uSegmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of vClosed</summary>
        public bool? vClosed
            {
            set { SetDatatypeProperty("vClosed", value); }
            get { var arr = GetDatatypeProperty_bool("vClosed"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access value of vCount</summary>
        public Int64? vCount
            {
            set { SetDatatypeProperty("vCount", value); }
            get { var arr = GetDatatypeProperty_Int64("vCount"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of vDegree</summary>
        public Int64? vDegree
            {
            set { SetDatatypeProperty("vDegree", value); }
            get { var arr = GetDatatypeProperty_Int64("vDegree"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access value of vSegmentationParts</summary>
        public Int64? vSegmentationParts
            {
            set { SetDatatypeProperty("vSegmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("vSegmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SplitConceptualFace
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SplitConceptualFace : GeometricItem
    {
        /// <summary>
        /// Create new instace of OWL class SplitConceptualFace and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SplitConceptualFace Create(Int64 model, string name=null) { return new SplitConceptualFace(Instance.Create(model, "SplitConceptualFace", name), "SplitConceptualFace");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SplitConceptualFace(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SplitConceptualFace") 
        {            
        }

        public static implicit operator SplitConceptualFace(Int64 instance) => new SplitConceptualFace(instance);


        //
        // Properties with known cardinality restrictions to SplitConceptualFace
        //

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                SetObjectProperty("object", value);
                }
            get
                {
                var propId = GetPropertyId("object");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new GeometricItem(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SpotLight
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SpotLight : DirectLight
    {
        /// <summary>
        /// Create new instace of OWL class SpotLight and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SpotLight Create(Int64 model, string name=null) { return new SpotLight(Instance.Create(model, "SpotLight", name), "SpotLight");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SpotLight(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SpotLight") 
        {            
        }

        public static implicit operator SpotLight(Int64 instance) => new SpotLight(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Surface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Surface : Face
    {
        /// <summary>
        /// Create new instace of OWL class Surface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Surface Create(Int64 model, string name=null) { return new Surface(Instance.Create(model, "Surface", name), "Surface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Surface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Surface") 
        {            
        }

        public static implicit operator Surface(Int64 instance) => new Surface(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SurfaceBySweptCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SurfaceBySweptCurve : FiniteSurface
    {
        /// <summary>
        /// Create new instace of OWL class SurfaceBySweptCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SurfaceBySweptCurve Create(Int64 model, string name=null) { return new SurfaceBySweptCurve(Instance.Create(model, "SurfaceBySweptCurve", name), "SurfaceBySweptCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SurfaceBySweptCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SurfaceBySweptCurve") 
        {            
        }

        public static implicit operator SurfaceBySweptCurve(Int64 instance) => new SurfaceBySweptCurve(instance);


        //
        // Properties with known cardinality restrictions to SurfaceBySweptCurve
        //

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                SetObjectProperty("path", value);
                }
            get
                {
                var propId = GetPropertyId("path");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve sweptArea
            {
            set
                {
                SetObjectProperty("sweptArea", value);
                }
            get
                {
                var propId = GetPropertyId("sweptArea");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] sweptAreaOpenings
            {
            set
                {
                SetObjectProperty("sweptAreaOpenings", value);
                }
            get
                {
                var propId = GetPropertyId("sweptAreaOpenings");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Curve[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Curve(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..-1</summary>
        public Int64[] sweptAreaOpenings_h
        {
            set
                {
                SetObjectProperty("sweptAreaOpenings", value);
                }
            get
                {
                var propId = GetPropertyId("sweptAreaOpenings");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SurfaceOfLinearExtrusion
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SurfaceOfLinearExtrusion : FiniteSurface
    {
        /// <summary>
        /// Create new instace of OWL class SurfaceOfLinearExtrusion and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SurfaceOfLinearExtrusion Create(Int64 model, string name=null) { return new SurfaceOfLinearExtrusion(Instance.Create(model, "SurfaceOfLinearExtrusion", name), "SurfaceOfLinearExtrusion");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SurfaceOfLinearExtrusion(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SurfaceOfLinearExtrusion") 
        {            
        }

        public static implicit operator SurfaceOfLinearExtrusion(Int64 instance) => new SurfaceOfLinearExtrusion(instance);


        //
        // Properties with known cardinality restrictions to SurfaceOfLinearExtrusion
        //

        ///<summary>Access relationship from this instance to an instance of Vector</summary>
        public Vector extrusion
            {
            set
                {
                SetObjectProperty("extrusion", value);
                }
            get
                {
                var propId = GetPropertyId("extrusion");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Vector(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve polygon
            {
            set
                {
                SetObjectProperty("polygon", value);
                }
            get
                {
                var propId = GetPropertyId("polygon");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SurfaceOfRevolution
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SurfaceOfRevolution : Surface
    {
        /// <summary>
        /// Create new instace of OWL class SurfaceOfRevolution and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SurfaceOfRevolution Create(Int64 model, string name=null) { return new SurfaceOfRevolution(Instance.Create(model, "SurfaceOfRevolution", name), "SurfaceOfRevolution");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SurfaceOfRevolution(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SurfaceOfRevolution") 
        {            
        }

        public static implicit operator SurfaceOfRevolution(Int64 instance) => new SurfaceOfRevolution(instance);


        //
        // Properties with known cardinality restrictions to SurfaceOfRevolution
        //

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                SetObjectProperty("path", value);
                }
            get
                {
                var propId = GetPropertyId("path");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SweptAreaSolid
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SweptAreaSolid : Solid
    {
        /// <summary>
        /// Create new instace of OWL class SweptAreaSolid and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SweptAreaSolid Create(Int64 model, string name=null) { return new SweptAreaSolid(Instance.Create(model, "SweptAreaSolid", name), "SweptAreaSolid");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SweptAreaSolid(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SweptAreaSolid") 
        {            
        }

        public static implicit operator SweptAreaSolid(Int64 instance) => new SweptAreaSolid(instance);


        //
        // Properties with known cardinality restrictions to SweptAreaSolid
        //

        ///<summary>Access relationship from this instance to an instance of Vector</summary>
        public Vector direction
            {
            set
                {
                SetObjectProperty("direction", value);
                }
            get
                {
                var propId = GetPropertyId("direction");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Vector(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { SetDatatypeProperty("fraction", value); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                SetObjectProperty("path", value);
                }
            get
                {
                var propId = GetPropertyId("path");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of setting</summary>
        public Int64? setting
            {
            set { SetDatatypeProperty("setting", value); }
            get { var arr = GetDatatypeProperty_Int64("setting"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve sweptArea
            {
            set
                {
                SetObjectProperty("sweptArea", value);
                }
            get
                {
                var propId = GetPropertyId("sweptArea");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] sweptAreaOpenings
            {
            set
                {
                SetObjectProperty("sweptAreaOpenings", value);
                }
            get
                {
                var propId = GetPropertyId("sweptAreaOpenings");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Curve[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Curve(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..-1</summary>
        public Int64[] sweptAreaOpenings_h
        {
            set
                {
                SetObjectProperty("sweptAreaOpenings", value);
                }
            get
                {
                var propId = GetPropertyId("sweptAreaOpenings");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SweptAreaSolidSet
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SweptAreaSolidSet : Solid
    {
        /// <summary>
        /// Create new instace of OWL class SweptAreaSolidSet and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SweptAreaSolidSet Create(Int64 model, string name=null) { return new SweptAreaSolidSet(Instance.Create(model, "SweptAreaSolidSet", name), "SweptAreaSolidSet");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SweptAreaSolidSet(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SweptAreaSolidSet") 
        {            
        }

        public static implicit operator SweptAreaSolidSet(Int64 instance) => new SweptAreaSolidSet(instance);


        //
        // Properties with known cardinality restrictions to SweptAreaSolidSet
        //

        ///<summary>Access relationship from this instance to an instance of Vector</summary>
        public Vector direction
            {
            set
                {
                SetObjectProperty("direction", value);
                }
            get
                {
                var propId = GetPropertyId("direction");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Vector(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { SetDatatypeProperty("fraction", value); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                SetObjectProperty("path", value);
                }
            get
                {
                var propId = GetPropertyId("path");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Curve[] sweptAreaSet
            {
            set
                {
                SetObjectProperty("sweptAreaSet", value);
                }
            get
                {
                var propId = GetPropertyId("sweptAreaSet");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Curve[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Curve(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 1..-1</summary>
        public Int64[] sweptAreaSet_h
        {
            set
                {
                SetObjectProperty("sweptAreaSet", value);
                }
            get
                {
                var propId = GetPropertyId("sweptAreaSet");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SweptAreaSolidTapered
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SweptAreaSolidTapered : Solid
    {
        /// <summary>
        /// Create new instace of OWL class SweptAreaSolidTapered and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SweptAreaSolidTapered Create(Int64 model, string name=null) { return new SweptAreaSolidTapered(Instance.Create(model, "SweptAreaSolidTapered", name), "SweptAreaSolidTapered");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SweptAreaSolidTapered(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SweptAreaSolidTapered") 
        {            
        }

        public static implicit operator SweptAreaSolidTapered(Int64 instance) => new SweptAreaSolidTapered(instance);


        //
        // Properties with known cardinality restrictions to SweptAreaSolidTapered
        //

        ///<summary>Access relationship from this instance to an instance of Vector</summary>
        public Vector direction
            {
            set
                {
                SetObjectProperty("direction", value);
                }
            get
                {
                var propId = GetPropertyId("direction");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Vector(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { SetDatatypeProperty("fraction", value); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                SetObjectProperty("path", value);
                }
            get
                {
                var propId = GetPropertyId("path");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve sweptArea
            {
            set
                {
                SetObjectProperty("sweptArea", value);
                }
            get
                {
                var propId = GetPropertyId("sweptArea");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve sweptAreaEnd
            {
            set
                {
                SetObjectProperty("sweptAreaEnd", value);
                }
            get
                {
                var propId = GetPropertyId("sweptAreaEnd");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] sweptAreaEndOpenings
            {
            set
                {
                SetObjectProperty("sweptAreaEndOpenings", value);
                }
            get
                {
                var propId = GetPropertyId("sweptAreaEndOpenings");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Curve[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Curve(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..-1</summary>
        public Int64[] sweptAreaEndOpenings_h
        {
            set
                {
                SetObjectProperty("sweptAreaEndOpenings", value);
                }
            get
                {
                var propId = GetPropertyId("sweptAreaEndOpenings");

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
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] sweptAreaOpenings
            {
            set
                {
                SetObjectProperty("sweptAreaOpenings", value);
                }
            get
                {
                var propId = GetPropertyId("sweptAreaOpenings");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Curve[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Curve(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..-1</summary>
        public Int64[] sweptAreaOpenings_h
        {
            set
                {
                SetObjectProperty("sweptAreaOpenings", value);
                }
            get
                {
                var propId = GetPropertyId("sweptAreaOpenings");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SweptBlend
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SweptBlend : Solid
    {
        /// <summary>
        /// Create new instace of OWL class SweptBlend and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SweptBlend Create(Int64 model, string name=null) { return new SweptBlend(Instance.Create(model, "SweptBlend", name), "SweptBlend");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SweptBlend(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SweptBlend") 
        {            
        }

        public static implicit operator SweptBlend(Int64 instance) => new SweptBlend(instance);


        //
        // Properties with known cardinality restrictions to SweptBlend
        //

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve bottomPolygon
            {
            set
                {
                SetObjectProperty("bottomPolygon", value);
                }
            get
                {
                var propId = GetPropertyId("bottomPolygon");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access values of connectionMap. OWL cardinality 0..-1</summary>
        public Int64[] connectionMap
            {
            set { SetDatatypeProperty("connectionMap", value); }
            get { return GetDatatypeProperty_Int64("connectionMap"); }
            }
        ///<summary>Access values of forcedStaticDirection. OWL cardinality 0..3</summary>
        public double[] forcedStaticDirection
            {
            set { SetDatatypeProperty("forcedStaticDirection", value); }
            get { return GetDatatypeProperty_double("forcedStaticDirection"); }
            }
        ///<summary>Access value of forceSolid</summary>
        public bool? forceSolid
            {
            set { SetDatatypeProperty("forceSolid", value); }
            get { var arr = GetDatatypeProperty_bool("forceSolid"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { SetDatatypeProperty("fraction", value); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of hasBottom</summary>
        public bool? hasBottom
            {
            set { SetDatatypeProperty("hasBottom", value); }
            get { var arr = GetDatatypeProperty_bool("hasBottom"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access value of hasTop</summary>
        public bool? hasTop
            {
            set { SetDatatypeProperty("hasTop", value); }
            get { var arr = GetDatatypeProperty_bool("hasTop"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                SetObjectProperty("path", value);
                }
            get
                {
                var propId = GetPropertyId("path");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve topPolygon
            {
            set
                {
                SetObjectProperty("topPolygon", value);
                }
            get
                {
                var propId = GetPropertyId("topPolygon");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of usesAbsolutePlacement</summary>
        public bool? usesAbsolutePlacement
            {
            set { SetDatatypeProperty("usesAbsolutePlacement", value); }
            get { var arr = GetDatatypeProperty_bool("usesAbsolutePlacement"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class SweptDiskSolid
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class SweptDiskSolid : Solid
    {
        /// <summary>
        /// Create new instace of OWL class SweptDiskSolid and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new SweptDiskSolid Create(Int64 model, string name=null) { return new SweptDiskSolid(Instance.Create(model, "SweptDiskSolid", name), "SweptDiskSolid");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public SweptDiskSolid(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "SweptDiskSolid") 
        {            
        }

        public static implicit operator SweptDiskSolid(Int64 instance) => new SweptDiskSolid(instance);


        //
        // Properties with known cardinality restrictions to SweptDiskSolid
        //

        ///<summary>Access value of innerRadius</summary>
        public double? innerRadius
            {
            set { SetDatatypeProperty("innerRadius", value); }
            get { var arr = GetDatatypeProperty_double("innerRadius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                SetObjectProperty("path", value);
                }
            get
                {
                var propId = GetPropertyId("path");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { SetDatatypeProperty("radius", value); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Texture
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Texture : Appearance
    {
        /// <summary>
        /// Create new instace of OWL class Texture and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Texture Create(Int64 model, string name=null) { return new Texture(Instance.Create(model, "Texture", name), "Texture");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Texture(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Texture") 
        {            
        }

        public static implicit operator Texture(Int64 instance) => new Texture(instance);


        //
        // Properties with known cardinality restrictions to Texture
        //

        ///<summary>Access value of name</summary>
        public string name
            {
            set { SetDatatypeProperty("name", value); }
            get { var arr = GetDatatypeProperty_string("name"); return (arr != null && arr.Length > 0) ? (string)arr[0] : null; }
            }
        ///<summary>Access value of offsetX</summary>
        public double? offsetX
            {
            set { SetDatatypeProperty("offsetX", value); }
            get { var arr = GetDatatypeProperty_double("offsetX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of offsetY</summary>
        public double? offsetY
            {
            set { SetDatatypeProperty("offsetY", value); }
            get { var arr = GetDatatypeProperty_double("offsetY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access values of origin. OWL cardinality 0..3</summary>
        public double[] origin
            {
            set { SetDatatypeProperty("origin", value); }
            get { return GetDatatypeProperty_double("origin"); }
            }
        ///<summary>Access value of rotation</summary>
        public double? rotation
            {
            set { SetDatatypeProperty("rotation", value); }
            get { var arr = GetDatatypeProperty_double("rotation"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of scalingX</summary>
        public double? scalingX
            {
            set { SetDatatypeProperty("scalingX", value); }
            get { var arr = GetDatatypeProperty_double("scalingX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of scalingY</summary>
        public double? scalingY
            {
            set { SetDatatypeProperty("scalingY", value); }
            get { var arr = GetDatatypeProperty_double("scalingY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of type</summary>
        public Int64? type
            {
            set { SetDatatypeProperty("type", value); }
            get { var arr = GetDatatypeProperty_Int64("type"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class ToroidalSurface
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class ToroidalSurface : FiniteSurface
    {
        /// <summary>
        /// Create new instace of OWL class ToroidalSurface and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new ToroidalSurface Create(Int64 model, string name=null) { return new ToroidalSurface(Instance.Create(model, "ToroidalSurface", name), "ToroidalSurface");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public ToroidalSurface(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "ToroidalSurface") 
        {            
        }

        public static implicit operator ToroidalSurface(Int64 instance) => new ToroidalSurface(instance);


        //
        // Properties with known cardinality restrictions to ToroidalSurface
        //

        ///<summary>Access value of majorRadius</summary>
        public double? majorRadius
            {
            set { SetDatatypeProperty("majorRadius", value); }
            get { var arr = GetDatatypeProperty_double("majorRadius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of minorRadius</summary>
        public double? minorRadius
            {
            set { SetDatatypeProperty("minorRadius", value); }
            get { var arr = GetDatatypeProperty_double("minorRadius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Torus
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Torus : Solid
    {
        /// <summary>
        /// Create new instace of OWL class Torus and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Torus Create(Int64 model, string name=null) { return new Torus(Instance.Create(model, "Torus", name), "Torus");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Torus(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Torus") 
        {            
        }

        public static implicit operator Torus(Int64 instance) => new Torus(instance);


        //
        // Properties with known cardinality restrictions to Torus
        //

        ///<summary>Access value of majorRadius</summary>
        public double? majorRadius
            {
            set { SetDatatypeProperty("majorRadius", value); }
            get { var arr = GetDatatypeProperty_double("majorRadius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of minorRadius</summary>
        public double? minorRadius
            {
            set { SetDatatypeProperty("minorRadius", value); }
            get { var arr = GetDatatypeProperty_double("minorRadius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Transformation
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Transformation : Curve
    {
        /// <summary>
        /// Create new instace of OWL class Transformation and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Transformation Create(Int64 model, string name=null) { return new Transformation(Instance.Create(model, "Transformation", name), "Transformation");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Transformation(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Transformation") 
        {            
        }

        public static implicit operator Transformation(Int64 instance) => new Transformation(instance);


        //
        // Properties with known cardinality restrictions to Transformation
        //

        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix matrix
            {
            set
                {
                SetObjectProperty("matrix", value);
                }
            get
                {
                var propId = GetPropertyId("matrix");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Matrix(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                SetObjectProperty("object", value);
                }
            get
                {
                var propId = GetPropertyId("object");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new GeometricItem(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of recalculateBBox</summary>
        public bool? recalculateBBox
            {
            set { SetDatatypeProperty("recalculateBBox", value); }
            get { var arr = GetDatatypeProperty_bool("recalculateBBox"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class TransitionalCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class TransitionalCurve : Curve
    {
        /// <summary>
        /// Create new instace of OWL class TransitionalCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new TransitionalCurve Create(Int64 model, string name=null) { return new TransitionalCurve(Instance.Create(model, "TransitionalCurve", name), "TransitionalCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public TransitionalCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "TransitionalCurve") 
        {            
        }

        public static implicit operator TransitionalCurve(Int64 instance) => new TransitionalCurve(instance);


        //
        // Properties with known cardinality restrictions to TransitionalCurve
        //

        ///<summary>Access relationship from this instance to an instance of Vector</summary>
        public Vector direction
            {
            set
                {
                SetObjectProperty("direction", value);
                }
            get
                {
                var propId = GetPropertyId("direction");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Vector(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { SetDatatypeProperty("length", value); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                SetObjectProperty("path", value);
                }
            get
                {
                var propId = GetPropertyId("path");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Curve(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of radiusI</summary>
        public double? radiusI
            {
            set { SetDatatypeProperty("radiusI", value); }
            get { var arr = GetDatatypeProperty_double("radiusI"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of radiusII</summary>
        public double? radiusII
            {
            set { SetDatatypeProperty("radiusII", value); }
            get { var arr = GetDatatypeProperty_double("radiusII"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { SetDatatypeProperty("segmentationParts", value); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class TriangleCurve
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class TriangleCurve : Curve
    {
        /// <summary>
        /// Create new instace of OWL class TriangleCurve and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new TriangleCurve Create(Int64 model, string name=null) { return new TriangleCurve(Instance.Create(model, "TriangleCurve", name), "TriangleCurve");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public TriangleCurve(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "TriangleCurve") 
        {            
        }

        public static implicit operator TriangleCurve(Int64 instance) => new TriangleCurve(instance);


        //
        // Properties with known cardinality restrictions to TriangleCurve
        //

        ///<summary>Access values of coordinates. OWL cardinality 0..9</summary>
        public double[] coordinates
            {
            set { SetDatatypeProperty("coordinates", value); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        ///<summary>Access value of offsetX</summary>
        public double? offsetX
            {
            set { SetDatatypeProperty("offsetX", value); }
            get { var arr = GetDatatypeProperty_double("offsetX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of offsetY</summary>
        public double? offsetY
            {
            set { SetDatatypeProperty("offsetY", value); }
            get { var arr = GetDatatypeProperty_double("offsetY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of offsetZ</summary>
        public double? offsetZ
            {
            set { SetDatatypeProperty("offsetZ", value); }
            get { var arr = GetDatatypeProperty_double("offsetZ"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access an array of related instances. OWL cardinality 0..3</summary>
        public Point[] pointReferences
            {
            set
                {
                SetObjectProperty("pointReferences", value);
                }
            get
                {
                var propId = GetPropertyId("pointReferences");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[card];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)card);

                    var ret = new Point[card];
                    for (int i = 0; i < card; i++)
                        {
                        ret[i] = new Point(values[i], null);
                        }

                    return ret;
                    }
                else
                    {
                    return null;
                    }
                }
            }

        ///<summary>Access an array of handles of related instances. OWL cardinality 0..3</summary>
        public Int64[] pointReferences_h
        {
            set
                {
                SetObjectProperty("pointReferences", value);
                }
            get
                {
                var propId = GetPropertyId("pointReferences");

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
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class TriangleReduction
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class TriangleReduction : Solid
    {
        /// <summary>
        /// Create new instace of OWL class TriangleReduction and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new TriangleReduction Create(Int64 model, string name=null) { return new TriangleReduction(Instance.Create(model, "TriangleReduction", name), "TriangleReduction");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public TriangleReduction(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "TriangleReduction") 
        {            
        }

        public static implicit operator TriangleReduction(Int64 instance) => new TriangleReduction(instance);


        //
        // Properties with known cardinality restrictions to TriangleReduction
        //

        ///<summary>Access value of innerFraction</summary>
        public double? innerFraction
            {
            set { SetDatatypeProperty("innerFraction", value); }
            get { var arr = GetDatatypeProperty_double("innerFraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                SetObjectProperty("object", value);
                }
            get
                {
                var propId = GetPropertyId("object");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new GeometricItem(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
        ///<summary>Access value of outerFraction</summary>
        public double? outerFraction
            {
            set { SetDatatypeProperty("outerFraction", value); }
            get { var arr = GetDatatypeProperty_double("outerFraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class TriangleSet
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class TriangleSet : Surface
    {
        /// <summary>
        /// Create new instace of OWL class TriangleSet and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new TriangleSet Create(Int64 model, string name=null) { return new TriangleSet(Instance.Create(model, "TriangleSet", name), "TriangleSet");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public TriangleSet(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "TriangleSet") 
        {            
        }

        public static implicit operator TriangleSet(Int64 instance) => new TriangleSet(instance);


        //
        // Properties with known cardinality restrictions to TriangleSet
        //

        ///<summary>Access values of indices. OWL cardinality 0..-1</summary>
        public Int64[] indices
            {
            set { SetDatatypeProperty("indices", value); }
            get { return GetDatatypeProperty_Int64("indices"); }
            }
        ///<summary>Access values of vertices. OWL cardinality 3..-1</summary>
        public double[] vertices
            {
            set { SetDatatypeProperty("vertices", value); }
            get { return GetDatatypeProperty_double("vertices"); }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Vector
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Vector : Mathematics
    {
        /// <summary>
        /// Create new instace of OWL class Vector and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Vector Create(Int64 model, string name=null) { return new Vector(Instance.Create(model, "Vector", name), "Vector");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Vector(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Vector") 
        {            
        }

        public static implicit operator Vector(Int64 instance) => new Vector(instance);

    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class Vector3
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class Vector3 : Vector
    {
        /// <summary>
        /// Create new instace of OWL class Vector3 and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new Vector3 Create(Int64 model, string name=null) { return new Vector3(Instance.Create(model, "Vector3", name), "Vector3");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public Vector3(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "Vector3") 
        {            
        }

        public static implicit operator Vector3(Int64 instance) => new Vector3(instance);


        //
        // Properties with known cardinality restrictions to Vector3
        //

        ///<summary>Access values of coordinates. OWL cardinality 0..3</summary>
        public double[] coordinates
            {
            set { SetDatatypeProperty("coordinates", value); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        ///<summary>Access value of x</summary>
        public double? x
            {
            set { SetDatatypeProperty("x", value); }
            get { var arr = GetDatatypeProperty_double("x"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of y</summary>
        public double? y
            {
            set { SetDatatypeProperty("y", value); }
            get { var arr = GetDatatypeProperty_double("y"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        ///<summary>Access value of z</summary>
        public double? z
            {
            set { SetDatatypeProperty("z", value); }
            get { var arr = GetDatatypeProperty_double("z"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class View
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class View : Environment
    {
        /// <summary>
        /// Create new instace of OWL class View and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new View Create(Int64 model, string name=null) { return new View(Instance.Create(model, "View", name), "View");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public View(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "View") 
        {            
        }

        public static implicit operator View(Int64 instance) => new View(instance);


        //
        // Properties with known cardinality restrictions to View
        //

        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix matrix
            {
            set
                {
                SetObjectProperty("matrix", value);
                }
            get
                {
                var propId = GetPropertyId("matrix");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Matrix(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


    /// <summary>
    /// Provides utility methods to interact with an instance of OWL class World
    /// You also can use object of this C# class instead of Int64 handle of the OWL instance in any place where the handle is required
    /// </summary>
    public class World : Environment
    {
        /// <summary>
        /// Create new instace of OWL class World and returns object of this C# class to interact with
        /// </summary>
        /// <param name="model">The handle to the model</param>
        /// <param name="name">This attribute represents the name of the instance (given as char array / ASCII). The name is given by the host and the attribute is not changed</param>
        /// <returns></returns>
        public static new World Create(Int64 model, string name=null) { return new World(Instance.Create(model, "World", name), "World");}
        
        /// <summary>
        /// Constructs object of this C# class that wraps existing OWL instance
        /// </summary>
        /// <param name="instance">OWL instance to interact with</param>
        /// <param name="checkClassName">Expected OWL class of the instance, used for diagnostic (optionally)</param>
        public World(Int64 instance, string checkClassName = null) 
            : base (instance, (checkClassName!=null) ? checkClassName : "World") 
        {            
        }

        public static implicit operator World(Int64 instance) => new World(instance);


        //
        // Properties with known cardinality restrictions to World
        //

        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix matrix
            {
            set
                {
                SetObjectProperty("matrix", value);
                }
            get
                {
                var propId = GetPropertyId("matrix");

                Int64 card = 0;
                IntPtr valuesPtr = IntPtr.Zero;
                var res = engine.GetObjectProperty(m_instance, propId, out valuesPtr, out card);
                System.Diagnostics.Debug.Assert(res == 0);

                if (card > 0)
                    {
                    var values = new Int64[1];
                    System.Runtime.InteropServices.Marshal.Copy(valuesPtr, values, 0, (int)1);

                    return new Matrix(values[0], null);
                    }
                else
                    {
                    return null;
                    }
                }
            }
    }


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
}

