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

        public bool Set_bounds(Curve[] value) {  return SetObjectProperty("bounds", value); }
        public bool Set_bounds(Int64[] value) {  return SetObjectProperty("bounds", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] bounds
            {
            set
                {
                if (!SetObjectProperty("bounds", value)) throw new SetPropertyException("bounds", m_instance);
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
                if (!SetObjectProperty("bounds", value)) throw new SetPropertyException("bounds", m_instance);
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
        public bool Set_surface(Int64 value) {  return SetObjectProperty("surface", value); }

        ///<summary>Access relationship from this instance to an instance of Surface</summary>
        public Surface surface
            {
            set
                {
                if (!SetObjectProperty("surface", value)) throw new SetPropertyException("surface", m_instance);
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

        public bool Set_clipped(bool? value) {  return SetDatatypeProperty("clipped", value); }
        ///<summary>Access value of clipped</summary>
        public bool? clipped
            {
            set { if (!SetDatatypeProperty("clipped", value)) throw new SetPropertyException("clipped", m_instance); }
            get { var arr = GetDatatypeProperty_bool("clipped"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_scalingX(double? value) {  return SetDatatypeProperty("scalingX", value); }
        ///<summary>Access value of scalingX</summary>
        public double? scalingX
            {
            set { if (!SetDatatypeProperty("scalingX", value)) throw new SetPropertyException("scalingX", m_instance); }
            get { var arr = GetDatatypeProperty_double("scalingX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_scalingY(double? value) {  return SetDatatypeProperty("scalingY", value); }
        ///<summary>Access value of scalingY</summary>
        public double? scalingY
            {
            set { if (!SetDatatypeProperty("scalingY", value)) throw new SetPropertyException("scalingY", m_instance); }
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

        public bool Set_isOuterBound(bool[] value) {  return SetDatatypeProperty("isOuterBound", value); }
        ///<summary>Access values of isOuterBound. OWL cardinality 0..-1</summary>
        public bool[] isOuterBound
            {
            set { if (!SetDatatypeProperty("isOuterBound", value)) throw new SetPropertyException("isOuterBound", m_instance); }
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

        public bool Set_scalingX(double? value) {  return SetDatatypeProperty("scalingX", value); }
        ///<summary>Access value of scalingX</summary>
        public double? scalingX
            {
            set { if (!SetDatatypeProperty("scalingX", value)) throw new SetPropertyException("scalingX", m_instance); }
            get { var arr = GetDatatypeProperty_double("scalingX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_scalingY(double? value) {  return SetDatatypeProperty("scalingY", value); }
        ///<summary>Access value of scalingY</summary>
        public double? scalingY
            {
            set { if (!SetDatatypeProperty("scalingY", value)) throw new SetPropertyException("scalingY", m_instance); }
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

        public bool Set_length(double? value) {  return SetDatatypeProperty("length", value); }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { if (!SetDatatypeProperty("length", value)) throw new SetPropertyException("length", m_instance); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_offsetX(double? value) {  return SetDatatypeProperty("offsetX", value); }
        ///<summary>Access value of offsetX</summary>
        public double? offsetX
            {
            set { if (!SetDatatypeProperty("offsetX", value)) throw new SetPropertyException("offsetX", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_offsetY(double? value) {  return SetDatatypeProperty("offsetY", value); }
        ///<summary>Access value of offsetY</summary>
        public double? offsetY
            {
            set { if (!SetDatatypeProperty("offsetY", value)) throw new SetPropertyException("offsetY", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segment(Int64 value) {  return SetObjectProperty("segment", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve segment
            {
            set
                {
                if (!SetObjectProperty("segment", value)) throw new SetPropertyException("segment", m_instance);
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
        public bool Set_tangentDirectionStart(double[] value) {  return SetDatatypeProperty("tangentDirectionStart", value); }
        ///<summary>Access values of tangentDirectionStart. OWL cardinality 3..3</summary>
        public double[] tangentDirectionStart
            {
            set { if (!SetDatatypeProperty("tangentDirectionStart", value)) throw new SetPropertyException("tangentDirectionStart", m_instance); }
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

        public bool Set_segments(AlignedSegment[] value) {  return SetObjectProperty("segments", value); }
        public bool Set_segments(Int64[] value) {  return SetObjectProperty("segments", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public AlignedSegment[] segments
            {
            set
                {
                if (!SetObjectProperty("segments", value)) throw new SetPropertyException("segments", m_instance);
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
                if (!SetObjectProperty("segments", value)) throw new SetPropertyException("segments", m_instance);
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

        public bool Set_horizontal(Int64 value) {  return SetObjectProperty("horizontal", value); }

        ///<summary>Access relationship from this instance to an instance of AlignedSegments</summary>
        public AlignedSegments horizontal
            {
            set
                {
                if (!SetObjectProperty("horizontal", value)) throw new SetPropertyException("horizontal", m_instance);
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
        public bool Set_offsetX(double? value) {  return SetDatatypeProperty("offsetX", value); }
        ///<summary>Access value of offsetX</summary>
        public double? offsetX
            {
            set { if (!SetDatatypeProperty("offsetX", value)) throw new SetPropertyException("offsetX", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_type(Int64? value) {  return SetDatatypeProperty("type", value); }
        ///<summary>Access value of type</summary>
        public Int64? type
            {
            set { if (!SetDatatypeProperty("type", value)) throw new SetPropertyException("type", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("type"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_vertical(Int64 value) {  return SetObjectProperty("vertical", value); }

        ///<summary>Access relationship from this instance to an instance of AlignedSegments</summary>
        public AlignedSegments vertical
            {
            set
                {
                if (!SetObjectProperty("vertical", value)) throw new SetPropertyException("vertical", m_instance);
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

        public bool Set_hasNormals(bool? value) {  return SetDatatypeProperty("hasNormals", value); }
        ///<summary>Access value of hasNormals</summary>
        public bool? hasNormals
            {
            set { if (!SetDatatypeProperty("hasNormals", value)) throw new SetPropertyException("hasNormals", m_instance); }
            get { var arr = GetDatatypeProperty_bool("hasNormals"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_radius(double? value) {  return SetDatatypeProperty("radius", value); }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { if (!SetDatatypeProperty("radius", value)) throw new SetPropertyException("radius", m_instance); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_size(double? value) {  return SetDatatypeProperty("size", value); }
        ///<summary>Access value of size</summary>
        public double? size
            {
            set { if (!SetDatatypeProperty("size", value)) throw new SetPropertyException("size", m_instance); }
            get { var arr = GetDatatypeProperty_double("size"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_start(double? value) {  return SetDatatypeProperty("start", value); }
        ///<summary>Access value of start</summary>
        public double? start
            {
            set { if (!SetDatatypeProperty("start", value)) throw new SetPropertyException("start", m_instance); }
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

        public bool Set_setting(Int64? value) {  return SetDatatypeProperty("setting", value); }
        ///<summary>Access value of setting</summary>
        public Int64? setting
            {
            set { if (!SetDatatypeProperty("setting", value)) throw new SetPropertyException("setting", m_instance); }
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

        public bool Set_bottomPolygon(Int64 value) {  return SetObjectProperty("bottomPolygon", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve bottomPolygon
            {
            set
                {
                if (!SetObjectProperty("bottomPolygon", value)) throw new SetPropertyException("bottomPolygon", m_instance);
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
        public bool Set_forceSolid(bool? value) {  return SetDatatypeProperty("forceSolid", value); }
        ///<summary>Access value of forceSolid</summary>
        public bool? forceSolid
            {
            set { if (!SetDatatypeProperty("forceSolid", value)) throw new SetPropertyException("forceSolid", m_instance); }
            get { var arr = GetDatatypeProperty_bool("forceSolid"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_fraction(double? value) {  return SetDatatypeProperty("fraction", value); }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { if (!SetDatatypeProperty("fraction", value)) throw new SetPropertyException("fraction", m_instance); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_hasBottom(bool? value) {  return SetDatatypeProperty("hasBottom", value); }
        ///<summary>Access value of hasBottom</summary>
        public bool? hasBottom
            {
            set { if (!SetDatatypeProperty("hasBottom", value)) throw new SetPropertyException("hasBottom", m_instance); }
            get { var arr = GetDatatypeProperty_bool("hasBottom"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_hasTop(bool? value) {  return SetDatatypeProperty("hasTop", value); }
        ///<summary>Access value of hasTop</summary>
        public bool? hasTop
            {
            set { if (!SetDatatypeProperty("hasTop", value)) throw new SetPropertyException("hasTop", m_instance); }
            get { var arr = GetDatatypeProperty_bool("hasTop"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_height(double? value) {  return SetDatatypeProperty("height", value); }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { if (!SetDatatypeProperty("height", value)) throw new SetPropertyException("height", m_instance); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_topPolygon(Int64 value) {  return SetObjectProperty("topPolygon", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve topPolygon
            {
            set
                {
                if (!SetObjectProperty("topPolygon", value)) throw new SetPropertyException("topPolygon", m_instance);
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

        public bool Set_deviation(Int64 value) {  return SetObjectProperty("deviation", value); }

        ///<summary>Access relationship from this instance to an instance of Deviation</summary>
        public Deviation deviation
            {
            set
                {
                if (!SetObjectProperty("deviation", value)) throw new SetPropertyException("deviation", m_instance);
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
        public bool Set_firstObject(Int64 value) {  return SetObjectProperty("firstObject", value); }

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem firstObject
            {
            set
                {
                if (!SetObjectProperty("firstObject", value)) throw new SetPropertyException("firstObject", m_instance);
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
        public bool Set_secondObject(Int64 value) {  return SetObjectProperty("secondObject", value); }

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem secondObject
            {
            set
                {
                if (!SetObjectProperty("secondObject", value)) throw new SetPropertyException("secondObject", m_instance);
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
        public bool Set_setting(Int64? value) {  return SetDatatypeProperty("setting", value); }
        ///<summary>Access value of setting</summary>
        public Int64? setting
            {
            set { if (!SetDatatypeProperty("setting", value)) throw new SetPropertyException("setting", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("setting"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_type(Int64? value) {  return SetDatatypeProperty("type", value); }
        ///<summary>Access value of type</summary>
        public Int64? type
            {
            set { if (!SetDatatypeProperty("type", value)) throw new SetPropertyException("type", m_instance); }
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

        public bool Set_deviation(Int64 value) {  return SetObjectProperty("deviation", value); }

        ///<summary>Access relationship from this instance to an instance of Deviation</summary>
        public Deviation deviation
            {
            set
                {
                if (!SetObjectProperty("deviation", value)) throw new SetPropertyException("deviation", m_instance);
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
        public bool Set_firstObject(Int64 value) {  return SetObjectProperty("firstObject", value); }

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem firstObject
            {
            set
                {
                if (!SetObjectProperty("firstObject", value)) throw new SetPropertyException("firstObject", m_instance);
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
        public bool Set_secondObject(Int64 value) {  return SetObjectProperty("secondObject", value); }

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem secondObject
            {
            set
                {
                if (!SetObjectProperty("secondObject", value)) throw new SetPropertyException("secondObject", m_instance);
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
        public bool Set_type(Int64? value) {  return SetDatatypeProperty("type", value); }
        ///<summary>Access value of type</summary>
        public Int64? type
            {
            set { if (!SetDatatypeProperty("type", value)) throw new SetPropertyException("type", m_instance); }
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

        public bool Set_consistencyCheck(Int64? value) {  return SetDatatypeProperty("consistencyCheck", value); }
        ///<summary>Access value of consistencyCheck</summary>
        public Int64? consistencyCheck
            {
            set { if (!SetDatatypeProperty("consistencyCheck", value)) throw new SetPropertyException("consistencyCheck", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("consistencyCheck"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_epsilon(double? value) {  return SetDatatypeProperty("epsilon", value); }
        ///<summary>Access value of epsilon</summary>
        public double? epsilon
            {
            set { if (!SetDatatypeProperty("epsilon", value)) throw new SetPropertyException("epsilon", m_instance); }
            get { var arr = GetDatatypeProperty_double("epsilon"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_faces(Face[] value) {  return SetObjectProperty("faces", value); }
        public bool Set_faces(Int64[] value) {  return SetObjectProperty("faces", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Face[] faces
            {
            set
                {
                if (!SetObjectProperty("faces", value)) throw new SetPropertyException("faces", m_instance);
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
                if (!SetObjectProperty("faces", value)) throw new SetPropertyException("faces", m_instance);
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
        public bool Set_flags(Int64[] value) {  return SetDatatypeProperty("flags", value); }
        ///<summary>Access values of flags. OWL cardinality 0..-1</summary>
        public Int64[] flags
            {
            set { if (!SetDatatypeProperty("flags", value)) throw new SetPropertyException("flags", m_instance); }
            get { return GetDatatypeProperty_Int64("flags"); }
            }
        public bool Set_fraction(double? value) {  return SetDatatypeProperty("fraction", value); }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { if (!SetDatatypeProperty("fraction", value)) throw new SetPropertyException("fraction", m_instance); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_indices(Int64[] value) {  return SetDatatypeProperty("indices", value); }
        ///<summary>Access values of indices. OWL cardinality 0..-1</summary>
        public Int64[] indices
            {
            set { if (!SetDatatypeProperty("indices", value)) throw new SetPropertyException("indices", m_instance); }
            get { return GetDatatypeProperty_Int64("indices"); }
            }
        public bool Set_normalCoordinates(double[] value) {  return SetDatatypeProperty("normalCoordinates", value); }
        ///<summary>Access values of normalCoordinates. OWL cardinality 0..-1</summary>
        public double[] normalCoordinates
            {
            set { if (!SetDatatypeProperty("normalCoordinates", value)) throw new SetPropertyException("normalCoordinates", m_instance); }
            get { return GetDatatypeProperty_double("normalCoordinates"); }
            }
        public bool Set_normalIndices(Int64[] value) {  return SetDatatypeProperty("normalIndices", value); }
        ///<summary>Access values of normalIndices. OWL cardinality 0..-1</summary>
        public Int64[] normalIndices
            {
            set { if (!SetDatatypeProperty("normalIndices", value)) throw new SetPropertyException("normalIndices", m_instance); }
            get { return GetDatatypeProperty_Int64("normalIndices"); }
            }
        public bool Set_relativeEpsilon(double? value) {  return SetDatatypeProperty("relativeEpsilon", value); }
        ///<summary>Access value of relativeEpsilon</summary>
        public double? relativeEpsilon
            {
            set { if (!SetDatatypeProperty("relativeEpsilon", value)) throw new SetPropertyException("relativeEpsilon", m_instance); }
            get { var arr = GetDatatypeProperty_double("relativeEpsilon"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_textureCoordinates(double[] value) {  return SetDatatypeProperty("textureCoordinates", value); }
        ///<summary>Access values of textureCoordinates. OWL cardinality 0..-1</summary>
        public double[] textureCoordinates
            {
            set { if (!SetDatatypeProperty("textureCoordinates", value)) throw new SetPropertyException("textureCoordinates", m_instance); }
            get { return GetDatatypeProperty_double("textureCoordinates"); }
            }
        public bool Set_textureIndices(Int64[] value) {  return SetDatatypeProperty("textureIndices", value); }
        ///<summary>Access values of textureIndices. OWL cardinality 0..-1</summary>
        public Int64[] textureIndices
            {
            set { if (!SetDatatypeProperty("textureIndices", value)) throw new SetPropertyException("textureIndices", m_instance); }
            get { return GetDatatypeProperty_Int64("textureIndices"); }
            }
        public bool Set_vertexEpsilon(double? value) {  return SetDatatypeProperty("vertexEpsilon", value); }
        ///<summary>Access value of vertexEpsilon</summary>
        public double? vertexEpsilon
            {
            set { if (!SetDatatypeProperty("vertexEpsilon", value)) throw new SetPropertyException("vertexEpsilon", m_instance); }
            get { var arr = GetDatatypeProperty_double("vertexEpsilon"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_vertices(double[] value) {  return SetDatatypeProperty("vertices", value); }
        ///<summary>Access values of vertices. OWL cardinality 0..-1</summary>
        public double[] vertices
            {
            set { if (!SetDatatypeProperty("vertices", value)) throw new SetPropertyException("vertices", m_instance); }
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

        public bool Set_height(double? value) {  return SetDatatypeProperty("height", value); }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { if (!SetDatatypeProperty("height", value)) throw new SetPropertyException("height", m_instance); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_length(double? value) {  return SetDatatypeProperty("length", value); }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { if (!SetDatatypeProperty("length", value)) throw new SetPropertyException("length", m_instance); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_width(double? value) {  return SetDatatypeProperty("width", value); }
        ///<summary>Access value of width</summary>
        public double? width
            {
            set { if (!SetDatatypeProperty("width", value)) throw new SetPropertyException("width", m_instance); }
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

        public bool Set_knotMultiplicities(Int64[] value) {  return SetDatatypeProperty("knotMultiplicities", value); }
        ///<summary>Access values of knotMultiplicities. OWL cardinality 0..-1</summary>
        public Int64[] knotMultiplicities
            {
            set { if (!SetDatatypeProperty("knotMultiplicities", value)) throw new SetPropertyException("knotMultiplicities", m_instance); }
            get { return GetDatatypeProperty_Int64("knotMultiplicities"); }
            }
        public bool Set_knots(double[] value) {  return SetDatatypeProperty("knots", value); }
        ///<summary>Access values of knots. OWL cardinality 2..-1</summary>
        public double[] knots
            {
            set { if (!SetDatatypeProperty("knots", value)) throw new SetPropertyException("knots", m_instance); }
            get { return GetDatatypeProperty_double("knots"); }
            }
        public bool Set_setting(Int64? value) {  return SetDatatypeProperty("setting", value); }
        ///<summary>Access value of setting</summary>
        public Int64? setting
            {
            set { if (!SetDatatypeProperty("setting", value)) throw new SetPropertyException("setting", m_instance); }
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

        public bool Set_setting(Int64? value) {  return SetDatatypeProperty("setting", value); }
        ///<summary>Access value of setting</summary>
        public Int64? setting
            {
            set { if (!SetDatatypeProperty("setting", value)) throw new SetPropertyException("setting", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("setting"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_uKnotMultiplicities(Int64[] value) {  return SetDatatypeProperty("uKnotMultiplicities", value); }
        ///<summary>Access values of uKnotMultiplicities. OWL cardinality 0..-1</summary>
        public Int64[] uKnotMultiplicities
            {
            set { if (!SetDatatypeProperty("uKnotMultiplicities", value)) throw new SetPropertyException("uKnotMultiplicities", m_instance); }
            get { return GetDatatypeProperty_Int64("uKnotMultiplicities"); }
            }
        public bool Set_uKnots(double[] value) {  return SetDatatypeProperty("uKnots", value); }
        ///<summary>Access values of uKnots. OWL cardinality 2..-1</summary>
        public double[] uKnots
            {
            set { if (!SetDatatypeProperty("uKnots", value)) throw new SetPropertyException("uKnots", m_instance); }
            get { return GetDatatypeProperty_double("uKnots"); }
            }
        public bool Set_vKnotMultiplicities(Int64[] value) {  return SetDatatypeProperty("vKnotMultiplicities", value); }
        ///<summary>Access values of vKnotMultiplicities. OWL cardinality 0..-1</summary>
        public Int64[] vKnotMultiplicities
            {
            set { if (!SetDatatypeProperty("vKnotMultiplicities", value)) throw new SetPropertyException("vKnotMultiplicities", m_instance); }
            get { return GetDatatypeProperty_Int64("vKnotMultiplicities"); }
            }
        public bool Set_vKnots(double[] value) {  return SetDatatypeProperty("vKnots", value); }
        ///<summary>Access values of vKnots. OWL cardinality 2..-1</summary>
        public double[] vKnots
            {
            set { if (!SetDatatypeProperty("vKnots", value)) throw new SetPropertyException("vKnots", m_instance); }
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

        public bool Set_pointReferences(Point[] value) {  return SetObjectProperty("pointReferences", value); }
        public bool Set_pointReferences(Int64[] value) {  return SetObjectProperty("pointReferences", value); }
        ///<summary>Access an array of related instances. OWL cardinality 3..3</summary>
        public Point[] pointReferences
            {
            set
                {
                if (!SetObjectProperty("pointReferences", value)) throw new SetPropertyException("pointReferences", m_instance);
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
                if (!SetObjectProperty("pointReferences", value)) throw new SetPropertyException("pointReferences", m_instance);
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

        public bool Set_coordinates(double[] value) {  return SetDatatypeProperty("coordinates", value); }
        ///<summary>Access values of coordinates. OWL cardinality 12..12</summary>
        public double[] coordinates
            {
            set { if (!SetDatatypeProperty("coordinates", value)) throw new SetPropertyException("coordinates", m_instance); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        public bool Set_points(double[] value) {  return SetDatatypeProperty("points", value); }
        ///<summary>Access values of points. OWL cardinality 0..12</summary>
        public double[] points
            {
            set { if (!SetDatatypeProperty("points", value)) throw new SetPropertyException("points", m_instance); }
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

        public bool Set_deviation(Int64 value) {  return SetObjectProperty("deviation", value); }

        ///<summary>Access relationship from this instance to an instance of Deviation</summary>
        public Deviation deviation
            {
            set
                {
                if (!SetObjectProperty("deviation", value)) throw new SetPropertyException("deviation", m_instance);
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
        public bool Set_object(Int64 value) {  return SetObjectProperty("object", value); }

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                if (!SetObjectProperty("object", value)) throw new SetPropertyException("object", m_instance);
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
        public bool Set_plane(Int64 value) {  return SetObjectProperty("plane", value); }

        ///<summary>Access relationship from this instance to an instance of Plane</summary>
        public Plane plane
            {
            set
                {
                if (!SetObjectProperty("plane", value)) throw new SetPropertyException("plane", m_instance);
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
        public bool Set_type(Int64? value) {  return SetDatatypeProperty("type", value); }
        ///<summary>Access value of type</summary>
        public Int64? type
            {
            set { if (!SetDatatypeProperty("type", value)) throw new SetPropertyException("type", m_instance); }
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

        public bool Set_A(double? value) {  return SetDatatypeProperty("A", value); }
        ///<summary>Access value of A</summary>
        public double? A
            {
            set { if (!SetDatatypeProperty("A", value)) throw new SetPropertyException("A", m_instance); }
            get { var arr = GetDatatypeProperty_double("A"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_direction(Int64 value) {  return SetObjectProperty("direction", value); }

        ///<summary>Access relationship from this instance to an instance of Vector</summary>
        public Vector direction
            {
            set
                {
                if (!SetObjectProperty("direction", value)) throw new SetPropertyException("direction", m_instance);
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
        public bool Set_length(double? value) {  return SetDatatypeProperty("length", value); }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { if (!SetDatatypeProperty("length", value)) throw new SetPropertyException("length", m_instance); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_orientation(Int64? value) {  return SetDatatypeProperty("orientation", value); }
        ///<summary>Access value of orientation</summary>
        public Int64? orientation
            {
            set { if (!SetDatatypeProperty("orientation", value)) throw new SetPropertyException("orientation", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("orientation"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_radius(double? value) {  return SetDatatypeProperty("radius", value); }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { if (!SetDatatypeProperty("radius", value)) throw new SetPropertyException("radius", m_instance); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_consistencyCheck(Int64? value) {  return SetDatatypeProperty("consistencyCheck", value); }
        ///<summary>Access value of consistencyCheck</summary>
        public Int64? consistencyCheck
            {
            set { if (!SetDatatypeProperty("consistencyCheck", value)) throw new SetPropertyException("consistencyCheck", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("consistencyCheck"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_epsilon(double? value) {  return SetDatatypeProperty("epsilon", value); }
        ///<summary>Access value of epsilon</summary>
        public double? epsilon
            {
            set { if (!SetDatatypeProperty("epsilon", value)) throw new SetPropertyException("epsilon", m_instance); }
            get { var arr = GetDatatypeProperty_double("epsilon"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_forceSolid(bool? value) {  return SetDatatypeProperty("forceSolid", value); }
        ///<summary>Access value of forceSolid</summary>
        public bool? forceSolid
            {
            set { if (!SetDatatypeProperty("forceSolid", value)) throw new SetPropertyException("forceSolid", m_instance); }
            get { var arr = GetDatatypeProperty_bool("forceSolid"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_fraction(double? value) {  return SetDatatypeProperty("fraction", value); }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { if (!SetDatatypeProperty("fraction", value)) throw new SetPropertyException("fraction", m_instance); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_objects(GeometricItem[] value) {  return SetObjectProperty("objects", value); }
        public bool Set_objects(Int64[] value) {  return SetObjectProperty("objects", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public GeometricItem[] objects
            {
            set
                {
                if (!SetObjectProperty("objects", value)) throw new SetPropertyException("objects", m_instance);
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
                if (!SetObjectProperty("objects", value)) throw new SetPropertyException("objects", m_instance);
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
        public bool Set_recalculateBBox(bool? value) {  return SetDatatypeProperty("recalculateBBox", value); }
        ///<summary>Access value of recalculateBBox</summary>
        public bool? recalculateBBox
            {
            set { if (!SetDatatypeProperty("recalculateBBox", value)) throw new SetPropertyException("recalculateBBox", m_instance); }
            get { var arr = GetDatatypeProperty_bool("recalculateBBox"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_relativeEpsilon(double? value) {  return SetDatatypeProperty("relativeEpsilon", value); }
        ///<summary>Access value of relativeEpsilon</summary>
        public double? relativeEpsilon
            {
            set { if (!SetDatatypeProperty("relativeEpsilon", value)) throw new SetPropertyException("relativeEpsilon", m_instance); }
            get { var arr = GetDatatypeProperty_double("relativeEpsilon"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_representsSolid(bool? value) {  return SetDatatypeProperty("representsSolid", value); }
        ///<summary>Access value of representsSolid</summary>
        public bool? representsSolid
            {
            set { if (!SetDatatypeProperty("representsSolid", value)) throw new SetPropertyException("representsSolid", m_instance); }
            get { var arr = GetDatatypeProperty_bool("representsSolid"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_vertexEpsilon(double? value) {  return SetDatatypeProperty("vertexEpsilon", value); }
        ///<summary>Access value of vertexEpsilon</summary>
        public double? vertexEpsilon
            {
            set { if (!SetDatatypeProperty("vertexEpsilon", value)) throw new SetPropertyException("vertexEpsilon", m_instance); }
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

        public bool Set_ambient(Int64 value) {  return SetObjectProperty("ambient", value); }

        ///<summary>Access relationship from this instance to an instance of ColorComponent</summary>
        public ColorComponent ambient
            {
            set
                {
                if (!SetObjectProperty("ambient", value)) throw new SetPropertyException("ambient", m_instance);
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
        public bool Set_ambientReflectance(double? value) {  return SetDatatypeProperty("ambientReflectance", value); }
        ///<summary>Access value of ambientReflectance</summary>
        public double? ambientReflectance
            {
            set { if (!SetDatatypeProperty("ambientReflectance", value)) throw new SetPropertyException("ambientReflectance", m_instance); }
            get { var arr = GetDatatypeProperty_double("ambientReflectance"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_diffuse(Int64 value) {  return SetObjectProperty("diffuse", value); }

        ///<summary>Access relationship from this instance to an instance of ColorComponent</summary>
        public ColorComponent diffuse
            {
            set
                {
                if (!SetObjectProperty("diffuse", value)) throw new SetPropertyException("diffuse", m_instance);
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
        public bool Set_emissive(Int64 value) {  return SetObjectProperty("emissive", value); }

        ///<summary>Access relationship from this instance to an instance of ColorComponent</summary>
        public ColorComponent emissive
            {
            set
                {
                if (!SetObjectProperty("emissive", value)) throw new SetPropertyException("emissive", m_instance);
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
        public bool Set_specular(Int64 value) {  return SetObjectProperty("specular", value); }

        ///<summary>Access relationship from this instance to an instance of ColorComponent</summary>
        public ColorComponent specular
            {
            set
                {
                if (!SetObjectProperty("specular", value)) throw new SetPropertyException("specular", m_instance);
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
        public bool Set_transparency(double? value) {  return SetDatatypeProperty("transparency", value); }
        ///<summary>Access value of transparency</summary>
        public double? transparency
            {
            set { if (!SetDatatypeProperty("transparency", value)) throw new SetPropertyException("transparency", m_instance); }
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

        public bool Set_B(double? value) {  return SetDatatypeProperty("B", value); }
        ///<summary>Access value of B</summary>
        public double? B
            {
            set { if (!SetDatatypeProperty("B", value)) throw new SetPropertyException("B", m_instance); }
            get { var arr = GetDatatypeProperty_double("B"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_G(double? value) {  return SetDatatypeProperty("G", value); }
        ///<summary>Access value of G</summary>
        public double? G
            {
            set { if (!SetDatatypeProperty("G", value)) throw new SetPropertyException("G", m_instance); }
            get { var arr = GetDatatypeProperty_double("G"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_R(double? value) {  return SetDatatypeProperty("R", value); }
        ///<summary>Access value of R</summary>
        public double? R
            {
            set { if (!SetDatatypeProperty("R", value)) throw new SetPropertyException("R", m_instance); }
            get { var arr = GetDatatypeProperty_double("R"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_W(double? value) {  return SetDatatypeProperty("W", value); }
        ///<summary>Access value of W</summary>
        public double? W
            {
            set { if (!SetDatatypeProperty("W", value)) throw new SetPropertyException("W", m_instance); }
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

        public bool Set_height(double? value) {  return SetDatatypeProperty("height", value); }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { if (!SetDatatypeProperty("height", value)) throw new SetPropertyException("height", m_instance); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_radius(double? value) {  return SetDatatypeProperty("radius", value); }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { if (!SetDatatypeProperty("radius", value)) throw new SetPropertyException("radius", m_instance); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_a(double? value) {  return SetDatatypeProperty("a", value); }
        ///<summary>Access value of a</summary>
        public double? a
            {
            set { if (!SetDatatypeProperty("a", value)) throw new SetPropertyException("a", m_instance); }
            get { var arr = GetDatatypeProperty_double("a"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_size(double? value) {  return SetDatatypeProperty("size", value); }
        ///<summary>Access value of size</summary>
        public double? size
            {
            set { if (!SetDatatypeProperty("size", value)) throw new SetPropertyException("size", m_instance); }
            get { var arr = GetDatatypeProperty_double("size"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_start(double? value) {  return SetDatatypeProperty("start", value); }
        ///<summary>Access value of start</summary>
        public double? start
            {
            set { if (!SetDatatypeProperty("start", value)) throw new SetPropertyException("start", m_instance); }
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

        public bool Set_height(double? value) {  return SetDatatypeProperty("height", value); }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { if (!SetDatatypeProperty("height", value)) throw new SetPropertyException("height", m_instance); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_radius(double? value) {  return SetDatatypeProperty("radius", value); }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { if (!SetDatatypeProperty("radius", value)) throw new SetPropertyException("radius", m_instance); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_semiVerticalAngle(double? value) {  return SetDatatypeProperty("semiVerticalAngle", value); }
        ///<summary>Access value of semiVerticalAngle</summary>
        public double? semiVerticalAngle
            {
            set { if (!SetDatatypeProperty("semiVerticalAngle", value)) throw new SetPropertyException("semiVerticalAngle", m_instance); }
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

        public bool Set_object(Int64 value) {  return SetObjectProperty("object", value); }

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                if (!SetObjectProperty("object", value)) throw new SetPropertyException("object", m_instance);
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

        public bool Set_instanceReference(Int64? value) {  return SetDatatypeProperty("instanceReference", value); }
        ///<summary>Access value of instanceReference</summary>
        public Int64? instanceReference
            {
            set { if (!SetDatatypeProperty("instanceReference", value)) throw new SetPropertyException("instanceReference", m_instance); }
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

        public bool Set_length(double? value) {  return SetDatatypeProperty("length", value); }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { if (!SetDatatypeProperty("length", value)) throw new SetPropertyException("length", m_instance); }
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

        public bool Set_height(double? value) {  return SetDatatypeProperty("height", value); }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { if (!SetDatatypeProperty("height", value)) throw new SetPropertyException("height", m_instance); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_length(double? value) {  return SetDatatypeProperty("length", value); }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { if (!SetDatatypeProperty("length", value)) throw new SetPropertyException("length", m_instance); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_width(double? value) {  return SetDatatypeProperty("width", value); }
        ///<summary>Access value of width</summary>
        public double? width
            {
            set { if (!SetDatatypeProperty("width", value)) throw new SetPropertyException("width", m_instance); }
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

        public bool Set_faces(Face[] value) {  return SetObjectProperty("faces", value); }
        public bool Set_faces(Int64[] value) {  return SetObjectProperty("faces", value); }
        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Face[] faces
            {
            set
                {
                if (!SetObjectProperty("faces", value)) throw new SetPropertyException("faces", m_instance);
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
                if (!SetObjectProperty("faces", value)) throw new SetPropertyException("faces", m_instance);
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

        public bool Set_length(double? value) {  return SetDatatypeProperty("length", value); }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { if (!SetDatatypeProperty("length", value)) throw new SetPropertyException("length", m_instance); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_radius(double? value) {  return SetDatatypeProperty("radius", value); }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { if (!SetDatatypeProperty("radius", value)) throw new SetPropertyException("radius", m_instance); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_radius(double? value) {  return SetDatatypeProperty("radius", value); }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { if (!SetDatatypeProperty("radius", value)) throw new SetPropertyException("radius", m_instance); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_majorRadius(double? value) {  return SetDatatypeProperty("majorRadius", value); }
        ///<summary>Access value of majorRadius</summary>
        public double? majorRadius
            {
            set { if (!SetDatatypeProperty("majorRadius", value)) throw new SetPropertyException("majorRadius", m_instance); }
            get { var arr = GetDatatypeProperty_double("majorRadius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_minorRadius(double? value) {  return SetDatatypeProperty("minorRadius", value); }
        ///<summary>Access value of minorRadius</summary>
        public double? minorRadius
            {
            set { if (!SetDatatypeProperty("minorRadius", value)) throw new SetPropertyException("minorRadius", m_instance); }
            get { var arr = GetDatatypeProperty_double("minorRadius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_absoluteEpsilon(double? value) {  return SetDatatypeProperty("absoluteEpsilon", value); }
        ///<summary>Access value of absoluteEpsilon</summary>
        public double? absoluteEpsilon
            {
            set { if (!SetDatatypeProperty("absoluteEpsilon", value)) throw new SetPropertyException("absoluteEpsilon", m_instance); }
            get { var arr = GetDatatypeProperty_double("absoluteEpsilon"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_relativeEpsilon(double? value) {  return SetDatatypeProperty("relativeEpsilon", value); }
        ///<summary>Access value of relativeEpsilon</summary>
        public double? relativeEpsilon
            {
            set { if (!SetDatatypeProperty("relativeEpsilon", value)) throw new SetPropertyException("relativeEpsilon", m_instance); }
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

        public bool Set_direction(Int64 value) {  return SetObjectProperty("direction", value); }

        ///<summary>Access relationship from this instance to an instance of Vector</summary>
        public Vector direction
            {
            set
                {
                if (!SetObjectProperty("direction", value)) throw new SetPropertyException("direction", m_instance);
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

        public bool Set_attenuation(double? value) {  return SetDatatypeProperty("attenuation", value); }
        ///<summary>Access value of attenuation</summary>
        public double? attenuation
            {
            set { if (!SetDatatypeProperty("attenuation", value)) throw new SetPropertyException("attenuation", m_instance); }
            get { var arr = GetDatatypeProperty_double("attenuation"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_range(double? value) {  return SetDatatypeProperty("range", value); }
        ///<summary>Access value of range</summary>
        public double? range
            {
            set { if (!SetDatatypeProperty("range", value)) throw new SetPropertyException("range", m_instance); }
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

        public bool Set_b(double? value) {  return SetDatatypeProperty("b", value); }
        ///<summary>Access value of b</summary>
        public double? b
            {
            set { if (!SetDatatypeProperty("b", value)) throw new SetPropertyException("b", m_instance); }
            get { var arr = GetDatatypeProperty_double("b"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_radiusI(double? value) {  return SetDatatypeProperty("radiusI", value); }
        ///<summary>Access value of radiusI</summary>
        public double? radiusI
            {
            set { if (!SetDatatypeProperty("radiusI", value)) throw new SetPropertyException("radiusI", m_instance); }
            get { var arr = GetDatatypeProperty_double("radiusI"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_radiusII(double? value) {  return SetDatatypeProperty("radiusII", value); }
        ///<summary>Access value of radiusII</summary>
        public double? radiusII
            {
            set { if (!SetDatatypeProperty("radiusII", value)) throw new SetPropertyException("radiusII", m_instance); }
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

        public bool Set_height(double? value) {  return SetDatatypeProperty("height", value); }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { if (!SetDatatypeProperty("height", value)) throw new SetPropertyException("height", m_instance); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_radiusI(double? value) {  return SetDatatypeProperty("radiusI", value); }
        ///<summary>Access value of radiusI</summary>
        public double? radiusI
            {
            set { if (!SetDatatypeProperty("radiusI", value)) throw new SetPropertyException("radiusI", m_instance); }
            get { var arr = GetDatatypeProperty_double("radiusI"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_radiusII(double? value) {  return SetDatatypeProperty("radiusII", value); }
        ///<summary>Access value of radiusII</summary>
        public double? radiusII
            {
            set { if (!SetDatatypeProperty("radiusII", value)) throw new SetPropertyException("radiusII", m_instance); }
            get { var arr = GetDatatypeProperty_double("radiusII"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_extrusionLength(double? value) {  return SetDatatypeProperty("extrusionLength", value); }
        ///<summary>Access value of extrusionLength</summary>
        public double? extrusionLength
            {
            set { if (!SetDatatypeProperty("extrusionLength", value)) throw new SetPropertyException("extrusionLength", m_instance); }
            get { var arr = GetDatatypeProperty_double("extrusionLength"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_fraction(double? value) {  return SetDatatypeProperty("fraction", value); }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { if (!SetDatatypeProperty("fraction", value)) throw new SetPropertyException("fraction", m_instance); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_openingPoints(double[] value) {  return SetDatatypeProperty("openingPoints", value); }
        ///<summary>Access values of openingPoints. OWL cardinality 0..-1</summary>
        public double[] openingPoints
            {
            set { if (!SetDatatypeProperty("openingPoints", value)) throw new SetPropertyException("openingPoints", m_instance); }
            get { return GetDatatypeProperty_double("openingPoints"); }
            }
        public bool Set_openingSizes(Int64[] value) {  return SetDatatypeProperty("openingSizes", value); }
        ///<summary>Access values of openingSizes. OWL cardinality 0..-1</summary>
        public Int64[] openingSizes
            {
            set { if (!SetDatatypeProperty("openingSizes", value)) throw new SetPropertyException("openingSizes", m_instance); }
            get { return GetDatatypeProperty_Int64("openingSizes"); }
            }
        public bool Set_points(double[] value) {  return SetDatatypeProperty("points", value); }
        ///<summary>Access values of points. OWL cardinality 6..-1</summary>
        public double[] points
            {
            set { if (!SetDatatypeProperty("points", value)) throw new SetPropertyException("points", m_instance); }
            get { return GetDatatypeProperty_double("points"); }
            }
        public bool Set_polygonDirection(double[] value) {  return SetDatatypeProperty("polygonDirection", value); }
        ///<summary>Access values of polygonDirection. OWL cardinality 0..3</summary>
        public double[] polygonDirection
            {
            set { if (!SetDatatypeProperty("polygonDirection", value)) throw new SetPropertyException("polygonDirection", m_instance); }
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

        public bool Set_extrusionLength(double? value) {  return SetDatatypeProperty("extrusionLength", value); }
        ///<summary>Access value of extrusionLength</summary>
        public double? extrusionLength
            {
            set { if (!SetDatatypeProperty("extrusionLength", value)) throw new SetPropertyException("extrusionLength", m_instance); }
            get { var arr = GetDatatypeProperty_double("extrusionLength"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_fraction(double? value) {  return SetDatatypeProperty("fraction", value); }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { if (!SetDatatypeProperty("fraction", value)) throw new SetPropertyException("fraction", m_instance); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_openingPoints(double[] value) {  return SetDatatypeProperty("openingPoints", value); }
        ///<summary>Access values of openingPoints. OWL cardinality 0..-1</summary>
        public double[] openingPoints
            {
            set { if (!SetDatatypeProperty("openingPoints", value)) throw new SetPropertyException("openingPoints", m_instance); }
            get { return GetDatatypeProperty_double("openingPoints"); }
            }
        public bool Set_openingPointsEnd(double[] value) {  return SetDatatypeProperty("openingPointsEnd", value); }
        ///<summary>Access values of openingPointsEnd. OWL cardinality 0..-1</summary>
        public double[] openingPointsEnd
            {
            set { if (!SetDatatypeProperty("openingPointsEnd", value)) throw new SetPropertyException("openingPointsEnd", m_instance); }
            get { return GetDatatypeProperty_double("openingPointsEnd"); }
            }
        public bool Set_openingSizes(Int64[] value) {  return SetDatatypeProperty("openingSizes", value); }
        ///<summary>Access values of openingSizes. OWL cardinality 0..-1</summary>
        public Int64[] openingSizes
            {
            set { if (!SetDatatypeProperty("openingSizes", value)) throw new SetPropertyException("openingSizes", m_instance); }
            get { return GetDatatypeProperty_Int64("openingSizes"); }
            }
        public bool Set_openingSizesEnd(Int64[] value) {  return SetDatatypeProperty("openingSizesEnd", value); }
        ///<summary>Access values of openingSizesEnd. OWL cardinality 0..-1</summary>
        public Int64[] openingSizesEnd
            {
            set { if (!SetDatatypeProperty("openingSizesEnd", value)) throw new SetPropertyException("openingSizesEnd", m_instance); }
            get { return GetDatatypeProperty_Int64("openingSizesEnd"); }
            }
        public bool Set_points(double[] value) {  return SetDatatypeProperty("points", value); }
        ///<summary>Access values of points. OWL cardinality 6..-1</summary>
        public double[] points
            {
            set { if (!SetDatatypeProperty("points", value)) throw new SetPropertyException("points", m_instance); }
            get { return GetDatatypeProperty_double("points"); }
            }
        public bool Set_pointsEnd(double[] value) {  return SetDatatypeProperty("pointsEnd", value); }
        ///<summary>Access values of pointsEnd. OWL cardinality 6..-1</summary>
        public double[] pointsEnd
            {
            set { if (!SetDatatypeProperty("pointsEnd", value)) throw new SetPropertyException("pointsEnd", m_instance); }
            get { return GetDatatypeProperty_double("pointsEnd"); }
            }
        public bool Set_polygonDirection(double[] value) {  return SetDatatypeProperty("polygonDirection", value); }
        ///<summary>Access values of polygonDirection. OWL cardinality 0..3</summary>
        public double[] polygonDirection
            {
            set { if (!SetDatatypeProperty("polygonDirection", value)) throw new SetPropertyException("polygonDirection", m_instance); }
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

        public bool Set_extrusionArea(Int64 value) {  return SetObjectProperty("extrusionArea", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve extrusionArea
            {
            set
                {
                if (!SetObjectProperty("extrusionArea", value)) throw new SetPropertyException("extrusionArea", m_instance);
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
        public bool Set_extrusionAreaOpenings(Curve[] value) {  return SetObjectProperty("extrusionAreaOpenings", value); }
        public bool Set_extrusionAreaOpenings(Int64[] value) {  return SetObjectProperty("extrusionAreaOpenings", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] extrusionAreaOpenings
            {
            set
                {
                if (!SetObjectProperty("extrusionAreaOpenings", value)) throw new SetPropertyException("extrusionAreaOpenings", m_instance);
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
                if (!SetObjectProperty("extrusionAreaOpenings", value)) throw new SetPropertyException("extrusionAreaOpenings", m_instance);
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
        public bool Set_extrusionDirection(double[] value) {  return SetDatatypeProperty("extrusionDirection", value); }
        ///<summary>Access values of extrusionDirection. OWL cardinality 0..3</summary>
        public double[] extrusionDirection
            {
            set { if (!SetDatatypeProperty("extrusionDirection", value)) throw new SetPropertyException("extrusionDirection", m_instance); }
            get { return GetDatatypeProperty_double("extrusionDirection"); }
            }
        public bool Set_extrusionLength(double? value) {  return SetDatatypeProperty("extrusionLength", value); }
        ///<summary>Access value of extrusionLength</summary>
        public double? extrusionLength
            {
            set { if (!SetDatatypeProperty("extrusionLength", value)) throw new SetPropertyException("extrusionLength", m_instance); }
            get { var arr = GetDatatypeProperty_double("extrusionLength"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_fraction(double? value) {  return SetDatatypeProperty("fraction", value); }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { if (!SetDatatypeProperty("fraction", value)) throw new SetPropertyException("fraction", m_instance); }
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

        public bool Set_extrusionAreaSet(Curve[] value) {  return SetObjectProperty("extrusionAreaSet", value); }
        public bool Set_extrusionAreaSet(Int64[] value) {  return SetObjectProperty("extrusionAreaSet", value); }
        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Curve[] extrusionAreaSet
            {
            set
                {
                if (!SetObjectProperty("extrusionAreaSet", value)) throw new SetPropertyException("extrusionAreaSet", m_instance);
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
                if (!SetObjectProperty("extrusionAreaSet", value)) throw new SetPropertyException("extrusionAreaSet", m_instance);
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
        public bool Set_extrusionDirection(double[] value) {  return SetDatatypeProperty("extrusionDirection", value); }
        ///<summary>Access values of extrusionDirection. OWL cardinality 0..3</summary>
        public double[] extrusionDirection
            {
            set { if (!SetDatatypeProperty("extrusionDirection", value)) throw new SetPropertyException("extrusionDirection", m_instance); }
            get { return GetDatatypeProperty_double("extrusionDirection"); }
            }
        public bool Set_extrusionLength(double? value) {  return SetDatatypeProperty("extrusionLength", value); }
        ///<summary>Access value of extrusionLength</summary>
        public double? extrusionLength
            {
            set { if (!SetDatatypeProperty("extrusionLength", value)) throw new SetPropertyException("extrusionLength", m_instance); }
            get { var arr = GetDatatypeProperty_double("extrusionLength"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_fraction(double? value) {  return SetDatatypeProperty("fraction", value); }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { if (!SetDatatypeProperty("fraction", value)) throw new SetPropertyException("fraction", m_instance); }
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

        public bool Set_innerPolygons(Curve[] value) {  return SetObjectProperty("innerPolygons", value); }
        public bool Set_innerPolygons(Int64[] value) {  return SetObjectProperty("innerPolygons", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] innerPolygons
            {
            set
                {
                if (!SetObjectProperty("innerPolygons", value)) throw new SetPropertyException("innerPolygons", m_instance);
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
                if (!SetObjectProperty("innerPolygons", value)) throw new SetPropertyException("innerPolygons", m_instance);
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
        public bool Set_outerPolygon(Int64 value) {  return SetObjectProperty("outerPolygon", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve outerPolygon
            {
            set
                {
                if (!SetObjectProperty("outerPolygon", value)) throw new SetPropertyException("outerPolygon", m_instance);
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
        public bool Set_setting(Int64? value) {  return SetDatatypeProperty("setting", value); }
        ///<summary>Access value of setting</summary>
        public Int64? setting
            {
            set { if (!SetDatatypeProperty("setting", value)) throw new SetPropertyException("setting", m_instance); }
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

        public bool Set_polygons(Curve[] value) {  return SetObjectProperty("polygons", value); }
        public bool Set_polygons(Int64[] value) {  return SetObjectProperty("polygons", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] polygons
            {
            set
                {
                if (!SetObjectProperty("polygons", value)) throw new SetPropertyException("polygons", m_instance);
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
                if (!SetObjectProperty("polygons", value)) throw new SetPropertyException("polygons", m_instance);
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
        public bool Set_setting(Int64? value) {  return SetDatatypeProperty("setting", value); }
        ///<summary>Access value of setting</summary>
        public Int64? setting
            {
            set { if (!SetDatatypeProperty("setting", value)) throw new SetPropertyException("setting", m_instance); }
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

        public bool Set_factor(double? value) {  return SetDatatypeProperty("factor", value); }
        ///<summary>Access value of factor</summary>
        public double? factor
            {
            set { if (!SetDatatypeProperty("factor", value)) throw new SetPropertyException("factor", m_instance); }
            get { var arr = GetDatatypeProperty_double("factor"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_height(double? value) {  return SetDatatypeProperty("height", value); }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { if (!SetDatatypeProperty("height", value)) throw new SetPropertyException("height", m_instance); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_radius(double? value) {  return SetDatatypeProperty("radius", value); }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { if (!SetDatatypeProperty("radius", value)) throw new SetPropertyException("radius", m_instance); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_material(Int64 value) {  return SetObjectProperty("material", value); }

        ///<summary>Access relationship from this instance to an instance of Material</summary>
        public Material material
            {
            set
                {
                if (!SetObjectProperty("material", value)) throw new SetPropertyException("material", m_instance);
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

        public bool Set_b(double? value) {  return SetDatatypeProperty("b", value); }
        ///<summary>Access value of b</summary>
        public double? b
            {
            set { if (!SetDatatypeProperty("b", value)) throw new SetPropertyException("b", m_instance); }
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

        public bool Set_surfaces(Surface[] value) {  return SetObjectProperty("surfaces", value); }
        public bool Set_surfaces(Int64[] value) {  return SetObjectProperty("surfaces", value); }
        ///<summary>Access an array of related instances. OWL cardinality 2..2</summary>
        public Surface[] surfaces
            {
            set
                {
                if (!SetObjectProperty("surfaces", value)) throw new SetPropertyException("surfaces", m_instance);
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
                if (!SetObjectProperty("surfaces", value)) throw new SetPropertyException("surfaces", m_instance);
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

        public bool Set_curve(Int64 value) {  return SetObjectProperty("curve", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve curve
            {
            set
                {
                if (!SetObjectProperty("curve", value)) throw new SetPropertyException("curve", m_instance);
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
        public bool Set_surface(Int64 value) {  return SetObjectProperty("surface", value); }

        ///<summary>Access relationship from this instance to an instance of Surface</summary>
        public Surface surface
            {
            set
                {
                if (!SetObjectProperty("surface", value)) throw new SetPropertyException("surface", m_instance);
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

        public bool Set_matrix(Int64 value) {  return SetObjectProperty("matrix", value); }

        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix matrix
            {
            set
                {
                if (!SetObjectProperty("matrix", value)) throw new SetPropertyException("matrix", m_instance);
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

        public bool Set_curve(Int64 value) {  return SetObjectProperty("curve", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve curve
            {
            set
                {
                if (!SetObjectProperty("curve", value)) throw new SetPropertyException("curve", m_instance);
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

        public bool Set_surface(Int64 value) {  return SetObjectProperty("surface", value); }

        ///<summary>Access relationship from this instance to an instance of Surface</summary>
        public Surface surface
            {
            set
                {
                if (!SetObjectProperty("surface", value)) throw new SetPropertyException("surface", m_instance);
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

        public bool Set_color(Int64 value) {  return SetObjectProperty("color", value); }

        ///<summary>Access relationship from this instance to an instance of Color</summary>
        public Color color
            {
            set
                {
                if (!SetObjectProperty("color", value)) throw new SetPropertyException("color", m_instance);
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

        public bool Set_asOpenGL(bool? value) {  return SetDatatypeProperty("asOpenGL", value); }
        ///<summary>Access value of asOpenGL</summary>
        public bool? asOpenGL
            {
            set { if (!SetDatatypeProperty("asOpenGL", value)) throw new SetPropertyException("asOpenGL", m_instance); }
            get { var arr = GetDatatypeProperty_bool("asOpenGL"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_points(double[] value) {  return SetDatatypeProperty("points", value); }
        ///<summary>Access values of points. OWL cardinality 6..6</summary>
        public double[] points
            {
            set { if (!SetDatatypeProperty("points", value)) throw new SetPropertyException("points", m_instance); }
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

        public bool Set_asOpenGL(bool? value) {  return SetDatatypeProperty("asOpenGL", value); }
        ///<summary>Access value of asOpenGL</summary>
        public bool? asOpenGL
            {
            set { if (!SetDatatypeProperty("asOpenGL", value)) throw new SetPropertyException("asOpenGL", m_instance); }
            get { var arr = GetDatatypeProperty_bool("asOpenGL"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_endDirection(double[] value) {  return SetDatatypeProperty("endDirection", value); }
        ///<summary>Access values of endDirection. OWL cardinality 0..3</summary>
        public double[] endDirection
            {
            set { if (!SetDatatypeProperty("endDirection", value)) throw new SetPropertyException("endDirection", m_instance); }
            get { return GetDatatypeProperty_double("endDirection"); }
            }
        public bool Set_points(double[] value) {  return SetDatatypeProperty("points", value); }
        ///<summary>Access values of points. OWL cardinality 0..6</summary>
        public double[] points
            {
            set { if (!SetDatatypeProperty("points", value)) throw new SetPropertyException("points", m_instance); }
            get { return GetDatatypeProperty_double("points"); }
            }
        public bool Set_startDirection(double[] value) {  return SetDatatypeProperty("startDirection", value); }
        ///<summary>Access values of startDirection. OWL cardinality 0..3</summary>
        public double[] startDirection
            {
            set { if (!SetDatatypeProperty("startDirection", value)) throw new SetPropertyException("startDirection", m_instance); }
            get { return GetDatatypeProperty_double("startDirection"); }
            }
        public bool Set_x0(double? value) {  return SetDatatypeProperty("x0", value); }
        ///<summary>Access value of x0</summary>
        public double? x0
            {
            set { if (!SetDatatypeProperty("x0", value)) throw new SetPropertyException("x0", m_instance); }
            get { var arr = GetDatatypeProperty_double("x0"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_x1(double? value) {  return SetDatatypeProperty("x1", value); }
        ///<summary>Access value of x1</summary>
        public double? x1
            {
            set { if (!SetDatatypeProperty("x1", value)) throw new SetPropertyException("x1", m_instance); }
            get { var arr = GetDatatypeProperty_double("x1"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_y0(double? value) {  return SetDatatypeProperty("y0", value); }
        ///<summary>Access value of y0</summary>
        public double? y0
            {
            set { if (!SetDatatypeProperty("y0", value)) throw new SetPropertyException("y0", m_instance); }
            get { var arr = GetDatatypeProperty_double("y0"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_y1(double? value) {  return SetDatatypeProperty("y1", value); }
        ///<summary>Access value of y1</summary>
        public double? y1
            {
            set { if (!SetDatatypeProperty("y1", value)) throw new SetPropertyException("y1", m_instance); }
            get { var arr = GetDatatypeProperty_double("y1"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_z0(double? value) {  return SetDatatypeProperty("z0", value); }
        ///<summary>Access value of z0</summary>
        public double? z0
            {
            set { if (!SetDatatypeProperty("z0", value)) throw new SetPropertyException("z0", m_instance); }
            get { var arr = GetDatatypeProperty_double("z0"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_z1(double? value) {  return SetDatatypeProperty("z1", value); }
        ///<summary>Access value of z1</summary>
        public double? z1
            {
            set { if (!SetDatatypeProperty("z1", value)) throw new SetPropertyException("z1", m_instance); }
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

        public bool Set_asOpenGL(bool? value) {  return SetDatatypeProperty("asOpenGL", value); }
        ///<summary>Access value of asOpenGL</summary>
        public bool? asOpenGL
            {
            set { if (!SetDatatypeProperty("asOpenGL", value)) throw new SetPropertyException("asOpenGL", m_instance); }
            get { var arr = GetDatatypeProperty_bool("asOpenGL"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_points(double[] value) {  return SetDatatypeProperty("points", value); }
        ///<summary>Access values of points. OWL cardinality 0..-1</summary>
        public double[] points
            {
            set { if (!SetDatatypeProperty("points", value)) throw new SetPropertyException("points", m_instance); }
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

        public bool Set_firstPoint(Int64 value) {  return SetObjectProperty("firstPoint", value); }

        ///<summary>Access relationship from this instance to an instance of Point</summary>
        public Point firstPoint
            {
            set
                {
                if (!SetObjectProperty("firstPoint", value)) throw new SetPropertyException("firstPoint", m_instance);
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
        public bool Set_secondPoint(Int64 value) {  return SetObjectProperty("secondPoint", value); }

        ///<summary>Access relationship from this instance to an instance of Point</summary>
        public Point secondPoint
            {
            set
                {
                if (!SetObjectProperty("secondPoint", value)) throw new SetPropertyException("secondPoint", m_instance);
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

        public bool Set_faces(Face[] value) {  return SetObjectProperty("faces", value); }
        public bool Set_faces(Int64[] value) {  return SetObjectProperty("faces", value); }
        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Face[] faces
            {
            set
                {
                if (!SetObjectProperty("faces", value)) throw new SetPropertyException("faces", m_instance);
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
                if (!SetObjectProperty("faces", value)) throw new SetPropertyException("faces", m_instance);
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

        public bool Set_color(Int64 value) {  return SetObjectProperty("color", value); }

        ///<summary>Access relationship from this instance to an instance of Color</summary>
        public Color color
            {
            set
                {
                if (!SetObjectProperty("color", value)) throw new SetPropertyException("color", m_instance);
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
        public bool Set_textures(Texture[] value) {  return SetObjectProperty("textures", value); }
        public bool Set_textures(Int64[] value) {  return SetObjectProperty("textures", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..2</summary>
        public Texture[] textures
            {
            set
                {
                if (!SetObjectProperty("textures", value)) throw new SetPropertyException("textures", m_instance);
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
                if (!SetObjectProperty("textures", value)) throw new SetPropertyException("textures", m_instance);
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

        public bool Set__11(double? value) {  return SetDatatypeProperty("_11", value); }
        ///<summary>Access value of _11</summary>
        public double? _11
            {
            set { if (!SetDatatypeProperty("_11", value)) throw new SetPropertyException("_11", m_instance); }
            get { var arr = GetDatatypeProperty_double("_11"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set__12(double? value) {  return SetDatatypeProperty("_12", value); }
        ///<summary>Access value of _12</summary>
        public double? _12
            {
            set { if (!SetDatatypeProperty("_12", value)) throw new SetPropertyException("_12", m_instance); }
            get { var arr = GetDatatypeProperty_double("_12"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set__13(double? value) {  return SetDatatypeProperty("_13", value); }
        ///<summary>Access value of _13</summary>
        public double? _13
            {
            set { if (!SetDatatypeProperty("_13", value)) throw new SetPropertyException("_13", m_instance); }
            get { var arr = GetDatatypeProperty_double("_13"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set__21(double? value) {  return SetDatatypeProperty("_21", value); }
        ///<summary>Access value of _21</summary>
        public double? _21
            {
            set { if (!SetDatatypeProperty("_21", value)) throw new SetPropertyException("_21", m_instance); }
            get { var arr = GetDatatypeProperty_double("_21"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set__22(double? value) {  return SetDatatypeProperty("_22", value); }
        ///<summary>Access value of _22</summary>
        public double? _22
            {
            set { if (!SetDatatypeProperty("_22", value)) throw new SetPropertyException("_22", m_instance); }
            get { var arr = GetDatatypeProperty_double("_22"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set__23(double? value) {  return SetDatatypeProperty("_23", value); }
        ///<summary>Access value of _23</summary>
        public double? _23
            {
            set { if (!SetDatatypeProperty("_23", value)) throw new SetPropertyException("_23", m_instance); }
            get { var arr = GetDatatypeProperty_double("_23"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set__31(double? value) {  return SetDatatypeProperty("_31", value); }
        ///<summary>Access value of _31</summary>
        public double? _31
            {
            set { if (!SetDatatypeProperty("_31", value)) throw new SetPropertyException("_31", m_instance); }
            get { var arr = GetDatatypeProperty_double("_31"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set__32(double? value) {  return SetDatatypeProperty("_32", value); }
        ///<summary>Access value of _32</summary>
        public double? _32
            {
            set { if (!SetDatatypeProperty("_32", value)) throw new SetPropertyException("_32", m_instance); }
            get { var arr = GetDatatypeProperty_double("_32"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set__33(double? value) {  return SetDatatypeProperty("_33", value); }
        ///<summary>Access value of _33</summary>
        public double? _33
            {
            set { if (!SetDatatypeProperty("_33", value)) throw new SetPropertyException("_33", m_instance); }
            get { var arr = GetDatatypeProperty_double("_33"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set__41(double? value) {  return SetDatatypeProperty("_41", value); }
        ///<summary>Access value of _41</summary>
        public double? _41
            {
            set { if (!SetDatatypeProperty("_41", value)) throw new SetPropertyException("_41", m_instance); }
            get { var arr = GetDatatypeProperty_double("_41"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set__42(double? value) {  return SetDatatypeProperty("_42", value); }
        ///<summary>Access value of _42</summary>
        public double? _42
            {
            set { if (!SetDatatypeProperty("_42", value)) throw new SetPropertyException("_42", m_instance); }
            get { var arr = GetDatatypeProperty_double("_42"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set__43(double? value) {  return SetDatatypeProperty("_43", value); }
        ///<summary>Access value of _43</summary>
        public double? _43
            {
            set { if (!SetDatatypeProperty("_43", value)) throw new SetPropertyException("_43", m_instance); }
            get { var arr = GetDatatypeProperty_double("_43"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_coordinates(double[] value) {  return SetDatatypeProperty("coordinates", value); }
        ///<summary>Access values of coordinates. OWL cardinality 0..12</summary>
        public double[] coordinates
            {
            set { if (!SetDatatypeProperty("coordinates", value)) throw new SetPropertyException("coordinates", m_instance); }
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

        public bool Set_firstMatrix(Int64 value) {  return SetObjectProperty("firstMatrix", value); }

        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix firstMatrix
            {
            set
                {
                if (!SetObjectProperty("firstMatrix", value)) throw new SetPropertyException("firstMatrix", m_instance);
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
        public bool Set_secondMatrix(Int64 value) {  return SetObjectProperty("secondMatrix", value); }

        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix secondMatrix
            {
            set
                {
                if (!SetObjectProperty("secondMatrix", value)) throw new SetPropertyException("secondMatrix", m_instance);
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

        public bool Set_pointSet(Int64 value) {  return SetObjectProperty("pointSet", value); }

        ///<summary>Access relationship from this instance to an instance of Point3DSet</summary>
        public Point3DSet pointSet
            {
            set
                {
                if (!SetObjectProperty("pointSet", value)) throw new SetPropertyException("pointSet", m_instance);
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

        public bool Set_objects(GeometricItem[] value) {  return SetObjectProperty("objects", value); }
        public bool Set_objects(Int64[] value) {  return SetObjectProperty("objects", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public GeometricItem[] objects
            {
            set
                {
                if (!SetObjectProperty("objects", value)) throw new SetPropertyException("objects", m_instance);
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
                if (!SetObjectProperty("objects", value)) throw new SetPropertyException("objects", m_instance);
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

        public bool Set_weights(double[] value) {  return SetDatatypeProperty("weights", value); }
        ///<summary>Access values of weights. OWL cardinality 2..-1</summary>
        public double[] weights
            {
            set { if (!SetDatatypeProperty("weights", value)) throw new SetPropertyException("weights", m_instance); }
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

        public bool Set_weights(double[] value) {  return SetDatatypeProperty("weights", value); }
        ///<summary>Access values of weights. OWL cardinality 4..-1</summary>
        public double[] weights
            {
            set { if (!SetDatatypeProperty("weights", value)) throw new SetPropertyException("weights", m_instance); }
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

        public bool Set_A(double? value) {  return SetDatatypeProperty("A", value); }
        ///<summary>Access value of A</summary>
        public double? A
            {
            set { if (!SetDatatypeProperty("A", value)) throw new SetPropertyException("A", m_instance); }
            get { var arr = GetDatatypeProperty_double("A"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_B(double? value) {  return SetDatatypeProperty("B", value); }
        ///<summary>Access value of B</summary>
        public double? B
            {
            set { if (!SetDatatypeProperty("B", value)) throw new SetPropertyException("B", m_instance); }
            get { var arr = GetDatatypeProperty_double("B"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_C(double? value) {  return SetDatatypeProperty("C", value); }
        ///<summary>Access value of C</summary>
        public double? C
            {
            set { if (!SetDatatypeProperty("C", value)) throw new SetPropertyException("C", m_instance); }
            get { var arr = GetDatatypeProperty_double("C"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_D(double? value) {  return SetDatatypeProperty("D", value); }
        ///<summary>Access value of D</summary>
        public double? D
            {
            set { if (!SetDatatypeProperty("D", value)) throw new SetPropertyException("D", m_instance); }
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

        public bool Set_plane(Int64 value) {  return SetObjectProperty("plane", value); }

        ///<summary>Access relationship from this instance to an instance of Plane</summary>
        public Plane plane
            {
            set
                {
                if (!SetObjectProperty("plane", value)) throw new SetPropertyException("plane", m_instance);
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

        public bool Set_asOpenGL(bool? value) {  return SetDatatypeProperty("asOpenGL", value); }
        ///<summary>Access value of asOpenGL</summary>
        public bool? asOpenGL
            {
            set { if (!SetDatatypeProperty("asOpenGL", value)) throw new SetPropertyException("asOpenGL", m_instance); }
            get { var arr = GetDatatypeProperty_bool("asOpenGL"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_coordinates(double[] value) {  return SetDatatypeProperty("coordinates", value); }
        ///<summary>Access values of coordinates. OWL cardinality 0..3</summary>
        public double[] coordinates
            {
            set { if (!SetDatatypeProperty("coordinates", value)) throw new SetPropertyException("coordinates", m_instance); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        public bool Set_points(double[] value) {  return SetDatatypeProperty("points", value); }
        ///<summary>Access values of points. OWL cardinality 0..3</summary>
        public double[] points
            {
            set { if (!SetDatatypeProperty("points", value)) throw new SetPropertyException("points", m_instance); }
            get { return GetDatatypeProperty_double("points"); }
            }
        public bool Set_x(double? value) {  return SetDatatypeProperty("x", value); }
        ///<summary>Access value of x</summary>
        public double? x
            {
            set { if (!SetDatatypeProperty("x", value)) throw new SetPropertyException("x", m_instance); }
            get { var arr = GetDatatypeProperty_double("x"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_y(double? value) {  return SetDatatypeProperty("y", value); }
        ///<summary>Access value of y</summary>
        public double? y
            {
            set { if (!SetDatatypeProperty("y", value)) throw new SetPropertyException("y", m_instance); }
            get { var arr = GetDatatypeProperty_double("y"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_z(double? value) {  return SetDatatypeProperty("z", value); }
        ///<summary>Access value of z</summary>
        public double? z
            {
            set { if (!SetDatatypeProperty("z", value)) throw new SetPropertyException("z", m_instance); }
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

        public bool Set_asOpenGL(bool? value) {  return SetDatatypeProperty("asOpenGL", value); }
        ///<summary>Access value of asOpenGL</summary>
        public bool? asOpenGL
            {
            set { if (!SetDatatypeProperty("asOpenGL", value)) throw new SetPropertyException("asOpenGL", m_instance); }
            get { var arr = GetDatatypeProperty_bool("asOpenGL"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_coordinates(double[] value) {  return SetDatatypeProperty("coordinates", value); }
        ///<summary>Access values of coordinates. OWL cardinality 0..-1</summary>
        public double[] coordinates
            {
            set { if (!SetDatatypeProperty("coordinates", value)) throw new SetPropertyException("coordinates", m_instance); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        public bool Set_points(double[] value) {  return SetDatatypeProperty("points", value); }
        ///<summary>Access values of points. OWL cardinality 0..-1</summary>
        public double[] points
            {
            set { if (!SetDatatypeProperty("points", value)) throw new SetPropertyException("points", m_instance); }
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

        public bool Set_object(Int64 value) {  return SetObjectProperty("object", value); }

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                if (!SetObjectProperty("object", value)) throw new SetPropertyException("object", m_instance);
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

        public bool Set_normal(Int64 value) {  return SetObjectProperty("normal", value); }

        ///<summary>Access relationship from this instance to an instance of Vector3</summary>
        public Vector3 normal
            {
            set
                {
                if (!SetObjectProperty("normal", value)) throw new SetPropertyException("normal", m_instance);
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
        public bool Set_point(Int64 value) {  return SetObjectProperty("point", value); }

        ///<summary>Access relationship from this instance to an instance of Point</summary>
        public Point point
            {
            set
                {
                if (!SetObjectProperty("point", value)) throw new SetPropertyException("point", m_instance);
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
        public bool Set_tangent(Int64 value) {  return SetObjectProperty("tangent", value); }

        ///<summary>Access relationship from this instance to an instance of Vector3</summary>
        public Vector3 tangent
            {
            set
                {
                if (!SetObjectProperty("tangent", value)) throw new SetPropertyException("tangent", m_instance);
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

        public bool Set_position(Int64 value) {  return SetObjectProperty("position", value); }

        ///<summary>Access relationship from this instance to an instance of Point3D</summary>
        public Point3D position
            {
            set
                {
                if (!SetObjectProperty("position", value)) throw new SetPropertyException("position", m_instance);
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

        public bool Set_coordinates(double[] value) {  return SetDatatypeProperty("coordinates", value); }
        ///<summary>Access values of coordinates. OWL cardinality 0..3</summary>
        public double[] coordinates
            {
            set { if (!SetDatatypeProperty("coordinates", value)) throw new SetPropertyException("coordinates", m_instance); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        public bool Set_x(double? value) {  return SetDatatypeProperty("x", value); }
        ///<summary>Access value of x</summary>
        public double? x
            {
            set { if (!SetDatatypeProperty("x", value)) throw new SetPropertyException("x", m_instance); }
            get { var arr = GetDatatypeProperty_double("x"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_y(double? value) {  return SetDatatypeProperty("y", value); }
        ///<summary>Access value of y</summary>
        public double? y
            {
            set { if (!SetDatatypeProperty("y", value)) throw new SetPropertyException("y", m_instance); }
            get { var arr = GetDatatypeProperty_double("y"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_z(double? value) {  return SetDatatypeProperty("z", value); }
        ///<summary>Access value of z</summary>
        public double? z
            {
            set { if (!SetDatatypeProperty("z", value)) throw new SetPropertyException("z", m_instance); }
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

        public bool Set_lineParts(Curve[] value) {  return SetObjectProperty("lineParts", value); }
        public bool Set_lineParts(Int64[] value) {  return SetObjectProperty("lineParts", value); }
        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Curve[] lineParts
            {
            set
                {
                if (!SetObjectProperty("lineParts", value)) throw new SetPropertyException("lineParts", m_instance);
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
                if (!SetObjectProperty("lineParts", value)) throw new SetPropertyException("lineParts", m_instance);
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

        public bool Set_lineParts(Curve[] value) {  return SetObjectProperty("lineParts", value); }
        public bool Set_lineParts(Int64[] value) {  return SetObjectProperty("lineParts", value); }
        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Curve[] lineParts
            {
            set
                {
                if (!SetObjectProperty("lineParts", value)) throw new SetPropertyException("lineParts", m_instance);
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
                if (!SetObjectProperty("lineParts", value)) throw new SetPropertyException("lineParts", m_instance);
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

        public bool Set_lineParts(Curve[] value) {  return SetObjectProperty("lineParts", value); }
        public bool Set_lineParts(Int64[] value) {  return SetObjectProperty("lineParts", value); }
        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Curve[] lineParts
            {
            set
                {
                if (!SetObjectProperty("lineParts", value)) throw new SetPropertyException("lineParts", m_instance);
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
                if (!SetObjectProperty("lineParts", value)) throw new SetPropertyException("lineParts", m_instance);
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

        public bool Set_coordinates(double[] value) {  return SetDatatypeProperty("coordinates", value); }
        ///<summary>Access values of coordinates. OWL cardinality 0..-1</summary>
        public double[] coordinates
            {
            set { if (!SetDatatypeProperty("coordinates", value)) throw new SetPropertyException("coordinates", m_instance); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        public bool Set_pointReferences(Point[] value) {  return SetObjectProperty("pointReferences", value); }
        public bool Set_pointReferences(Int64[] value) {  return SetObjectProperty("pointReferences", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Point[] pointReferences
            {
            set
                {
                if (!SetObjectProperty("pointReferences", value)) throw new SetPropertyException("pointReferences", m_instance);
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
                if (!SetObjectProperty("pointReferences", value)) throw new SetPropertyException("pointReferences", m_instance);
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
        public bool Set_points(double[] value) {  return SetDatatypeProperty("points", value); }
        ///<summary>Access values of points. OWL cardinality 0..-1</summary>
        public double[] points
            {
            set { if (!SetDatatypeProperty("points", value)) throw new SetPropertyException("points", m_instance); }
            get { return GetDatatypeProperty_double("points"); }
            }
        public bool Set_tangentArray(double[] value) {  return SetDatatypeProperty("tangentArray", value); }
        ///<summary>Access values of tangentArray. OWL cardinality 0..-1</summary>
        public double[] tangentArray
            {
            set { if (!SetDatatypeProperty("tangentArray", value)) throw new SetPropertyException("tangentArray", m_instance); }
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

        public bool Set_height(double? value) {  return SetDatatypeProperty("height", value); }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { if (!SetDatatypeProperty("height", value)) throw new SetPropertyException("height", m_instance); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_length(double? value) {  return SetDatatypeProperty("length", value); }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { if (!SetDatatypeProperty("length", value)) throw new SetPropertyException("length", m_instance); }
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

        public bool Set_innerPolygons(Curve[] value) {  return SetObjectProperty("innerPolygons", value); }
        public bool Set_innerPolygons(Int64[] value) {  return SetObjectProperty("innerPolygons", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] innerPolygons
            {
            set
                {
                if (!SetObjectProperty("innerPolygons", value)) throw new SetPropertyException("innerPolygons", m_instance);
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
                if (!SetObjectProperty("innerPolygons", value)) throw new SetPropertyException("innerPolygons", m_instance);
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
        public bool Set_outerPolygon(Int64 value) {  return SetObjectProperty("outerPolygon", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve outerPolygon
            {
            set
                {
                if (!SetObjectProperty("outerPolygon", value)) throw new SetPropertyException("outerPolygon", m_instance);
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

        public bool Set_matrix(Int64 value) {  return SetObjectProperty("matrix", value); }

        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix matrix
            {
            set
                {
                if (!SetObjectProperty("matrix", value)) throw new SetPropertyException("matrix", m_instance);
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

        public bool Set_height(double? value) {  return SetDatatypeProperty("height", value); }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { if (!SetDatatypeProperty("height", value)) throw new SetPropertyException("height", m_instance); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_length(double? value) {  return SetDatatypeProperty("length", value); }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { if (!SetDatatypeProperty("length", value)) throw new SetPropertyException("length", m_instance); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_width(double? value) {  return SetDatatypeProperty("width", value); }
        ///<summary>Access value of width</summary>
        public double? width
            {
            set { if (!SetDatatypeProperty("width", value)) throw new SetPropertyException("width", m_instance); }
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

        public bool Set_weights(double[] value) {  return SetDatatypeProperty("weights", value); }
        ///<summary>Access values of weights. OWL cardinality 2..-1</summary>
        public double[] weights
            {
            set { if (!SetDatatypeProperty("weights", value)) throw new SetPropertyException("weights", m_instance); }
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

        public bool Set_weights(double[] value) {  return SetDatatypeProperty("weights", value); }
        ///<summary>Access values of weights. OWL cardinality 4..-1</summary>
        public double[] weights
            {
            set { if (!SetDatatypeProperty("weights", value)) throw new SetPropertyException("weights", m_instance); }
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

        public bool Set_height(double? value) {  return SetDatatypeProperty("height", value); }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { if (!SetDatatypeProperty("height", value)) throw new SetPropertyException("height", m_instance); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_offsetX(double? value) {  return SetDatatypeProperty("offsetX", value); }
        ///<summary>Access value of offsetX</summary>
        public double? offsetX
            {
            set { if (!SetDatatypeProperty("offsetX", value)) throw new SetPropertyException("offsetX", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_offsetY(double? value) {  return SetDatatypeProperty("offsetY", value); }
        ///<summary>Access value of offsetY</summary>
        public double? offsetY
            {
            set { if (!SetDatatypeProperty("offsetY", value)) throw new SetPropertyException("offsetY", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_offsetZ(double? value) {  return SetDatatypeProperty("offsetZ", value); }
        ///<summary>Access value of offsetZ</summary>
        public double? offsetZ
            {
            set { if (!SetDatatypeProperty("offsetZ", value)) throw new SetPropertyException("offsetZ", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetZ"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_width(double? value) {  return SetDatatypeProperty("width", value); }
        ///<summary>Access value of width</summary>
        public double? width
            {
            set { if (!SetDatatypeProperty("width", value)) throw new SetPropertyException("width", m_instance); }
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

        public bool Set_count(Int64? value) {  return SetDatatypeProperty("count", value); }
        ///<summary>Access value of count</summary>
        public Int64? count
            {
            set { if (!SetDatatypeProperty("count", value)) throw new SetPropertyException("count", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("count"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_matrix(Int64 value) {  return SetObjectProperty("matrix", value); }

        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix matrix
            {
            set
                {
                if (!SetObjectProperty("matrix", value)) throw new SetPropertyException("matrix", m_instance);
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
        public bool Set_object(Int64 value) {  return SetObjectProperty("object", value); }

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                if (!SetObjectProperty("object", value)) throw new SetPropertyException("object", m_instance);
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

        public bool Set_lightDirection(Int64 value) {  return SetObjectProperty("lightDirection", value); }

        ///<summary>Access relationship from this instance to an instance of Vector3</summary>
        public Vector3 lightDirection
            {
            set
                {
                if (!SetObjectProperty("lightDirection", value)) throw new SetPropertyException("lightDirection", m_instance);
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
        public bool Set_lightPoint(Int64 value) {  return SetObjectProperty("lightPoint", value); }

        ///<summary>Access relationship from this instance to an instance of Point3D</summary>
        public Point3D lightPoint
            {
            set
                {
                if (!SetObjectProperty("lightPoint", value)) throw new SetPropertyException("lightPoint", m_instance);
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
        public bool Set_object(Int64 value) {  return SetObjectProperty("object", value); }

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                if (!SetObjectProperty("object", value)) throw new SetPropertyException("object", m_instance);
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
        public bool Set_plane(Int64 value) {  return SetObjectProperty("plane", value); }

        ///<summary>Access relationship from this instance to an instance of Plane</summary>
        public Plane plane
            {
            set
                {
                if (!SetObjectProperty("plane", value)) throw new SetPropertyException("plane", m_instance);
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
        public bool Set_planeRefDirection(Int64 value) {  return SetObjectProperty("planeRefDirection", value); }

        ///<summary>Access relationship from this instance to an instance of Vector3</summary>
        public Vector3 planeRefDirection
            {
            set
                {
                if (!SetObjectProperty("planeRefDirection", value)) throw new SetPropertyException("planeRefDirection", m_instance);
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
        public bool Set_type(Int64? value) {  return SetDatatypeProperty("type", value); }
        ///<summary>Access value of type</summary>
        public Int64? type
            {
            set { if (!SetDatatypeProperty("type", value)) throw new SetPropertyException("type", m_instance); }
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

        public bool Set_height(double? value) {  return SetDatatypeProperty("height", value); }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { if (!SetDatatypeProperty("height", value)) throw new SetPropertyException("height", m_instance); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_offsetX(double? value) {  return SetDatatypeProperty("offsetX", value); }
        ///<summary>Access value of offsetX</summary>
        public double? offsetX
            {
            set { if (!SetDatatypeProperty("offsetX", value)) throw new SetPropertyException("offsetX", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_offsetY(double? value) {  return SetDatatypeProperty("offsetY", value); }
        ///<summary>Access value of offsetY</summary>
        public double? offsetY
            {
            set { if (!SetDatatypeProperty("offsetY", value)) throw new SetPropertyException("offsetY", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_radius(double? value) {  return SetDatatypeProperty("radius", value); }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { if (!SetDatatypeProperty("radius", value)) throw new SetPropertyException("radius", m_instance); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_factor(double? value) {  return SetDatatypeProperty("factor", value); }
        ///<summary>Access value of factor</summary>
        public double? factor
            {
            set { if (!SetDatatypeProperty("factor", value)) throw new SetPropertyException("factor", m_instance); }
            get { var arr = GetDatatypeProperty_double("factor"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_height(double? value) {  return SetDatatypeProperty("height", value); }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { if (!SetDatatypeProperty("height", value)) throw new SetPropertyException("height", m_instance); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_offsetX(double? value) {  return SetDatatypeProperty("offsetX", value); }
        ///<summary>Access value of offsetX</summary>
        public double? offsetX
            {
            set { if (!SetDatatypeProperty("offsetX", value)) throw new SetPropertyException("offsetX", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_offsetY(double? value) {  return SetDatatypeProperty("offsetY", value); }
        ///<summary>Access value of offsetY</summary>
        public double? offsetY
            {
            set { if (!SetDatatypeProperty("offsetY", value)) throw new SetPropertyException("offsetY", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_radius(double? value) {  return SetDatatypeProperty("radius", value); }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { if (!SetDatatypeProperty("radius", value)) throw new SetPropertyException("radius", m_instance); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_faces(Face[] value) {  return SetObjectProperty("faces", value); }
        public bool Set_faces(Int64[] value) {  return SetObjectProperty("faces", value); }
        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Face[] faces
            {
            set
                {
                if (!SetObjectProperty("faces", value)) throw new SetPropertyException("faces", m_instance);
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
                if (!SetObjectProperty("faces", value)) throw new SetPropertyException("faces", m_instance);
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

        public bool Set_coordinates(double[] value) {  return SetDatatypeProperty("coordinates", value); }
        ///<summary>Access values of coordinates. OWL cardinality 0..6</summary>
        public double[] coordinates
            {
            set { if (!SetDatatypeProperty("coordinates", value)) throw new SetPropertyException("coordinates", m_instance); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_thickness(double? value) {  return SetDatatypeProperty("thickness", value); }
        ///<summary>Access value of thickness</summary>
        public double? thickness
            {
            set { if (!SetDatatypeProperty("thickness", value)) throw new SetPropertyException("thickness", m_instance); }
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

        public bool Set_radius(double? value) {  return SetDatatypeProperty("radius", value); }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { if (!SetDatatypeProperty("radius", value)) throw new SetPropertyException("radius", m_instance); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_invert(bool? value) {  return SetDatatypeProperty("invert", value); }
        ///<summary>Access value of invert</summary>
        public bool? invert
            {
            set { if (!SetDatatypeProperty("invert", value)) throw new SetPropertyException("invert", m_instance); }
            get { var arr = GetDatatypeProperty_bool("invert"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_radius(double? value) {  return SetDatatypeProperty("radius", value); }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { if (!SetDatatypeProperty("radius", value)) throw new SetPropertyException("radius", m_instance); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_height(double? value) {  return SetDatatypeProperty("height", value); }
        ///<summary>Access value of height</summary>
        public double? height
            {
            set { if (!SetDatatypeProperty("height", value)) throw new SetPropertyException("height", m_instance); }
            get { var arr = GetDatatypeProperty_double("height"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_offsetZ(double? value) {  return SetDatatypeProperty("offsetZ", value); }
        ///<summary>Access value of offsetZ</summary>
        public double? offsetZ
            {
            set { if (!SetDatatypeProperty("offsetZ", value)) throw new SetPropertyException("offsetZ", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetZ"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_radius(double? value) {  return SetDatatypeProperty("radius", value); }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { if (!SetDatatypeProperty("radius", value)) throw new SetPropertyException("radius", m_instance); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_size(double? value) {  return SetDatatypeProperty("size", value); }
        ///<summary>Access value of size</summary>
        public double? size
            {
            set { if (!SetDatatypeProperty("size", value)) throw new SetPropertyException("size", m_instance); }
            get { var arr = GetDatatypeProperty_double("size"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_start(double? value) {  return SetDatatypeProperty("start", value); }
        ///<summary>Access value of start</summary>
        public double? start
            {
            set { if (!SetDatatypeProperty("start", value)) throw new SetPropertyException("start", m_instance); }
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

        public bool Set_closed(bool? value) {  return SetDatatypeProperty("closed", value); }
        ///<summary>Access value of closed</summary>
        public bool? closed
            {
            set { if (!SetDatatypeProperty("closed", value)) throw new SetPropertyException("closed", m_instance); }
            get { var arr = GetDatatypeProperty_bool("closed"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_controlPoints(Point3D[] value) {  return SetObjectProperty("controlPoints", value); }
        public bool Set_controlPoints(Int64[] value) {  return SetObjectProperty("controlPoints", value); }
        ///<summary>Access an array of related instances. OWL cardinality 2..-1</summary>
        public Point3D[] controlPoints
            {
            set
                {
                if (!SetObjectProperty("controlPoints", value)) throw new SetPropertyException("controlPoints", m_instance);
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
                if (!SetObjectProperty("controlPoints", value)) throw new SetPropertyException("controlPoints", m_instance);
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
        public bool Set_count(Int64? value) {  return SetDatatypeProperty("count", value); }
        ///<summary>Access value of count</summary>
        public Int64? count
            {
            set { if (!SetDatatypeProperty("count", value)) throw new SetPropertyException("count", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("count"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_degree(Int64? value) {  return SetDatatypeProperty("degree", value); }
        ///<summary>Access value of degree</summary>
        public Int64? degree
            {
            set { if (!SetDatatypeProperty("degree", value)) throw new SetPropertyException("degree", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("degree"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_segmentationLength(double? value) {  return SetDatatypeProperty("segmentationLength", value); }
        ///<summary>Access value of segmentationLength</summary>
        public double? segmentationLength
            {
            set { if (!SetDatatypeProperty("segmentationLength", value)) throw new SetPropertyException("segmentationLength", m_instance); }
            get { var arr = GetDatatypeProperty_double("segmentationLength"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_controlPoints(Point3D[] value) {  return SetObjectProperty("controlPoints", value); }
        public bool Set_controlPoints(Int64[] value) {  return SetObjectProperty("controlPoints", value); }
        ///<summary>Access an array of related instances. OWL cardinality 4..-1</summary>
        public Point3D[] controlPoints
            {
            set
                {
                if (!SetObjectProperty("controlPoints", value)) throw new SetPropertyException("controlPoints", m_instance);
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
                if (!SetObjectProperty("controlPoints", value)) throw new SetPropertyException("controlPoints", m_instance);
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
        public bool Set_segmentationLength(double? value) {  return SetDatatypeProperty("segmentationLength", value); }
        ///<summary>Access value of segmentationLength</summary>
        public double? segmentationLength
            {
            set { if (!SetDatatypeProperty("segmentationLength", value)) throw new SetPropertyException("segmentationLength", m_instance); }
            get { var arr = GetDatatypeProperty_double("segmentationLength"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("segmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_uClosed(bool? value) {  return SetDatatypeProperty("uClosed", value); }
        ///<summary>Access value of uClosed</summary>
        public bool? uClosed
            {
            set { if (!SetDatatypeProperty("uClosed", value)) throw new SetPropertyException("uClosed", m_instance); }
            get { var arr = GetDatatypeProperty_bool("uClosed"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_uCount(Int64? value) {  return SetDatatypeProperty("uCount", value); }
        ///<summary>Access value of uCount</summary>
        public Int64? uCount
            {
            set { if (!SetDatatypeProperty("uCount", value)) throw new SetPropertyException("uCount", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("uCount"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_uDegree(Int64? value) {  return SetDatatypeProperty("uDegree", value); }
        ///<summary>Access value of uDegree</summary>
        public Int64? uDegree
            {
            set { if (!SetDatatypeProperty("uDegree", value)) throw new SetPropertyException("uDegree", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("uDegree"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_uSegmentationParts(Int64? value) {  return SetDatatypeProperty("uSegmentationParts", value); }
        ///<summary>Access value of uSegmentationParts</summary>
        public Int64? uSegmentationParts
            {
            set { if (!SetDatatypeProperty("uSegmentationParts", value)) throw new SetPropertyException("uSegmentationParts", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("uSegmentationParts"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_vClosed(bool? value) {  return SetDatatypeProperty("vClosed", value); }
        ///<summary>Access value of vClosed</summary>
        public bool? vClosed
            {
            set { if (!SetDatatypeProperty("vClosed", value)) throw new SetPropertyException("vClosed", m_instance); }
            get { var arr = GetDatatypeProperty_bool("vClosed"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_vCount(Int64? value) {  return SetDatatypeProperty("vCount", value); }
        ///<summary>Access value of vCount</summary>
        public Int64? vCount
            {
            set { if (!SetDatatypeProperty("vCount", value)) throw new SetPropertyException("vCount", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("vCount"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_vDegree(Int64? value) {  return SetDatatypeProperty("vDegree", value); }
        ///<summary>Access value of vDegree</summary>
        public Int64? vDegree
            {
            set { if (!SetDatatypeProperty("vDegree", value)) throw new SetPropertyException("vDegree", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("vDegree"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_vSegmentationParts(Int64? value) {  return SetDatatypeProperty("vSegmentationParts", value); }
        ///<summary>Access value of vSegmentationParts</summary>
        public Int64? vSegmentationParts
            {
            set { if (!SetDatatypeProperty("vSegmentationParts", value)) throw new SetPropertyException("vSegmentationParts", m_instance); }
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

        public bool Set_object(Int64 value) {  return SetObjectProperty("object", value); }

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                if (!SetObjectProperty("object", value)) throw new SetPropertyException("object", m_instance);
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

        public bool Set_path(Int64 value) {  return SetObjectProperty("path", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                if (!SetObjectProperty("path", value)) throw new SetPropertyException("path", m_instance);
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
        public bool Set_sweptArea(Int64 value) {  return SetObjectProperty("sweptArea", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve sweptArea
            {
            set
                {
                if (!SetObjectProperty("sweptArea", value)) throw new SetPropertyException("sweptArea", m_instance);
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
        public bool Set_sweptAreaOpenings(Curve[] value) {  return SetObjectProperty("sweptAreaOpenings", value); }
        public bool Set_sweptAreaOpenings(Int64[] value) {  return SetObjectProperty("sweptAreaOpenings", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] sweptAreaOpenings
            {
            set
                {
                if (!SetObjectProperty("sweptAreaOpenings", value)) throw new SetPropertyException("sweptAreaOpenings", m_instance);
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
                if (!SetObjectProperty("sweptAreaOpenings", value)) throw new SetPropertyException("sweptAreaOpenings", m_instance);
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

        public bool Set_extrusion(Int64 value) {  return SetObjectProperty("extrusion", value); }

        ///<summary>Access relationship from this instance to an instance of Vector</summary>
        public Vector extrusion
            {
            set
                {
                if (!SetObjectProperty("extrusion", value)) throw new SetPropertyException("extrusion", m_instance);
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
        public bool Set_polygon(Int64 value) {  return SetObjectProperty("polygon", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve polygon
            {
            set
                {
                if (!SetObjectProperty("polygon", value)) throw new SetPropertyException("polygon", m_instance);
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

        public bool Set_path(Int64 value) {  return SetObjectProperty("path", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                if (!SetObjectProperty("path", value)) throw new SetPropertyException("path", m_instance);
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
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_direction(Int64 value) {  return SetObjectProperty("direction", value); }

        ///<summary>Access relationship from this instance to an instance of Vector</summary>
        public Vector direction
            {
            set
                {
                if (!SetObjectProperty("direction", value)) throw new SetPropertyException("direction", m_instance);
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
        public bool Set_fraction(double? value) {  return SetDatatypeProperty("fraction", value); }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { if (!SetDatatypeProperty("fraction", value)) throw new SetPropertyException("fraction", m_instance); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_path(Int64 value) {  return SetObjectProperty("path", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                if (!SetObjectProperty("path", value)) throw new SetPropertyException("path", m_instance);
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
        public bool Set_setting(Int64? value) {  return SetDatatypeProperty("setting", value); }
        ///<summary>Access value of setting</summary>
        public Int64? setting
            {
            set { if (!SetDatatypeProperty("setting", value)) throw new SetPropertyException("setting", m_instance); }
            get { var arr = GetDatatypeProperty_Int64("setting"); return (arr != null && arr.Length > 0) ? (Int64?)arr[0] : null; }
            }
        public bool Set_sweptArea(Int64 value) {  return SetObjectProperty("sweptArea", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve sweptArea
            {
            set
                {
                if (!SetObjectProperty("sweptArea", value)) throw new SetPropertyException("sweptArea", m_instance);
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
        public bool Set_sweptAreaOpenings(Curve[] value) {  return SetObjectProperty("sweptAreaOpenings", value); }
        public bool Set_sweptAreaOpenings(Int64[] value) {  return SetObjectProperty("sweptAreaOpenings", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] sweptAreaOpenings
            {
            set
                {
                if (!SetObjectProperty("sweptAreaOpenings", value)) throw new SetPropertyException("sweptAreaOpenings", m_instance);
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
                if (!SetObjectProperty("sweptAreaOpenings", value)) throw new SetPropertyException("sweptAreaOpenings", m_instance);
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

        public bool Set_direction(Int64 value) {  return SetObjectProperty("direction", value); }

        ///<summary>Access relationship from this instance to an instance of Vector</summary>
        public Vector direction
            {
            set
                {
                if (!SetObjectProperty("direction", value)) throw new SetPropertyException("direction", m_instance);
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
        public bool Set_fraction(double? value) {  return SetDatatypeProperty("fraction", value); }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { if (!SetDatatypeProperty("fraction", value)) throw new SetPropertyException("fraction", m_instance); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_path(Int64 value) {  return SetObjectProperty("path", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                if (!SetObjectProperty("path", value)) throw new SetPropertyException("path", m_instance);
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
        public bool Set_sweptAreaSet(Curve[] value) {  return SetObjectProperty("sweptAreaSet", value); }
        public bool Set_sweptAreaSet(Int64[] value) {  return SetObjectProperty("sweptAreaSet", value); }
        ///<summary>Access an array of related instances. OWL cardinality 1..-1</summary>
        public Curve[] sweptAreaSet
            {
            set
                {
                if (!SetObjectProperty("sweptAreaSet", value)) throw new SetPropertyException("sweptAreaSet", m_instance);
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
                if (!SetObjectProperty("sweptAreaSet", value)) throw new SetPropertyException("sweptAreaSet", m_instance);
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

        public bool Set_direction(Int64 value) {  return SetObjectProperty("direction", value); }

        ///<summary>Access relationship from this instance to an instance of Vector</summary>
        public Vector direction
            {
            set
                {
                if (!SetObjectProperty("direction", value)) throw new SetPropertyException("direction", m_instance);
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
        public bool Set_fraction(double? value) {  return SetDatatypeProperty("fraction", value); }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { if (!SetDatatypeProperty("fraction", value)) throw new SetPropertyException("fraction", m_instance); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_path(Int64 value) {  return SetObjectProperty("path", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                if (!SetObjectProperty("path", value)) throw new SetPropertyException("path", m_instance);
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
        public bool Set_sweptArea(Int64 value) {  return SetObjectProperty("sweptArea", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve sweptArea
            {
            set
                {
                if (!SetObjectProperty("sweptArea", value)) throw new SetPropertyException("sweptArea", m_instance);
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
        public bool Set_sweptAreaEnd(Int64 value) {  return SetObjectProperty("sweptAreaEnd", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve sweptAreaEnd
            {
            set
                {
                if (!SetObjectProperty("sweptAreaEnd", value)) throw new SetPropertyException("sweptAreaEnd", m_instance);
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
        public bool Set_sweptAreaEndOpenings(Curve[] value) {  return SetObjectProperty("sweptAreaEndOpenings", value); }
        public bool Set_sweptAreaEndOpenings(Int64[] value) {  return SetObjectProperty("sweptAreaEndOpenings", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] sweptAreaEndOpenings
            {
            set
                {
                if (!SetObjectProperty("sweptAreaEndOpenings", value)) throw new SetPropertyException("sweptAreaEndOpenings", m_instance);
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
                if (!SetObjectProperty("sweptAreaEndOpenings", value)) throw new SetPropertyException("sweptAreaEndOpenings", m_instance);
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
        public bool Set_sweptAreaOpenings(Curve[] value) {  return SetObjectProperty("sweptAreaOpenings", value); }
        public bool Set_sweptAreaOpenings(Int64[] value) {  return SetObjectProperty("sweptAreaOpenings", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..-1</summary>
        public Curve[] sweptAreaOpenings
            {
            set
                {
                if (!SetObjectProperty("sweptAreaOpenings", value)) throw new SetPropertyException("sweptAreaOpenings", m_instance);
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
                if (!SetObjectProperty("sweptAreaOpenings", value)) throw new SetPropertyException("sweptAreaOpenings", m_instance);
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

        public bool Set_bottomPolygon(Int64 value) {  return SetObjectProperty("bottomPolygon", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve bottomPolygon
            {
            set
                {
                if (!SetObjectProperty("bottomPolygon", value)) throw new SetPropertyException("bottomPolygon", m_instance);
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
        public bool Set_connectionMap(Int64[] value) {  return SetDatatypeProperty("connectionMap", value); }
        ///<summary>Access values of connectionMap. OWL cardinality 0..-1</summary>
        public Int64[] connectionMap
            {
            set { if (!SetDatatypeProperty("connectionMap", value)) throw new SetPropertyException("connectionMap", m_instance); }
            get { return GetDatatypeProperty_Int64("connectionMap"); }
            }
        public bool Set_forcedStaticDirection(double[] value) {  return SetDatatypeProperty("forcedStaticDirection", value); }
        ///<summary>Access values of forcedStaticDirection. OWL cardinality 0..3</summary>
        public double[] forcedStaticDirection
            {
            set { if (!SetDatatypeProperty("forcedStaticDirection", value)) throw new SetPropertyException("forcedStaticDirection", m_instance); }
            get { return GetDatatypeProperty_double("forcedStaticDirection"); }
            }
        public bool Set_forceSolid(bool? value) {  return SetDatatypeProperty("forceSolid", value); }
        ///<summary>Access value of forceSolid</summary>
        public bool? forceSolid
            {
            set { if (!SetDatatypeProperty("forceSolid", value)) throw new SetPropertyException("forceSolid", m_instance); }
            get { var arr = GetDatatypeProperty_bool("forceSolid"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_fraction(double? value) {  return SetDatatypeProperty("fraction", value); }
        ///<summary>Access value of fraction</summary>
        public double? fraction
            {
            set { if (!SetDatatypeProperty("fraction", value)) throw new SetPropertyException("fraction", m_instance); }
            get { var arr = GetDatatypeProperty_double("fraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_hasBottom(bool? value) {  return SetDatatypeProperty("hasBottom", value); }
        ///<summary>Access value of hasBottom</summary>
        public bool? hasBottom
            {
            set { if (!SetDatatypeProperty("hasBottom", value)) throw new SetPropertyException("hasBottom", m_instance); }
            get { var arr = GetDatatypeProperty_bool("hasBottom"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_hasTop(bool? value) {  return SetDatatypeProperty("hasTop", value); }
        ///<summary>Access value of hasTop</summary>
        public bool? hasTop
            {
            set { if (!SetDatatypeProperty("hasTop", value)) throw new SetPropertyException("hasTop", m_instance); }
            get { var arr = GetDatatypeProperty_bool("hasTop"); return (arr != null && arr.Length > 0) ? (bool?)arr[0] : null; }
            }
        public bool Set_path(Int64 value) {  return SetObjectProperty("path", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                if (!SetObjectProperty("path", value)) throw new SetPropertyException("path", m_instance);
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
        public bool Set_topPolygon(Int64 value) {  return SetObjectProperty("topPolygon", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve topPolygon
            {
            set
                {
                if (!SetObjectProperty("topPolygon", value)) throw new SetPropertyException("topPolygon", m_instance);
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
        public bool Set_usesAbsolutePlacement(bool? value) {  return SetDatatypeProperty("usesAbsolutePlacement", value); }
        ///<summary>Access value of usesAbsolutePlacement</summary>
        public bool? usesAbsolutePlacement
            {
            set { if (!SetDatatypeProperty("usesAbsolutePlacement", value)) throw new SetPropertyException("usesAbsolutePlacement", m_instance); }
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

        public bool Set_innerRadius(double? value) {  return SetDatatypeProperty("innerRadius", value); }
        ///<summary>Access value of innerRadius</summary>
        public double? innerRadius
            {
            set { if (!SetDatatypeProperty("innerRadius", value)) throw new SetPropertyException("innerRadius", m_instance); }
            get { var arr = GetDatatypeProperty_double("innerRadius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_path(Int64 value) {  return SetObjectProperty("path", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                if (!SetObjectProperty("path", value)) throw new SetPropertyException("path", m_instance);
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
        public bool Set_radius(double? value) {  return SetDatatypeProperty("radius", value); }
        ///<summary>Access value of radius</summary>
        public double? radius
            {
            set { if (!SetDatatypeProperty("radius", value)) throw new SetPropertyException("radius", m_instance); }
            get { var arr = GetDatatypeProperty_double("radius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_name(string value) {  return SetDatatypeProperty("name", value); }
        ///<summary>Access value of name</summary>
        public string name
            {
            set { if (!SetDatatypeProperty("name", value)) throw new SetPropertyException("name", m_instance); }
            get { var arr = GetDatatypeProperty_string("name"); return (arr != null && arr.Length > 0) ? (string)arr[0] : null; }
            }
        public bool Set_offsetX(double? value) {  return SetDatatypeProperty("offsetX", value); }
        ///<summary>Access value of offsetX</summary>
        public double? offsetX
            {
            set { if (!SetDatatypeProperty("offsetX", value)) throw new SetPropertyException("offsetX", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_offsetY(double? value) {  return SetDatatypeProperty("offsetY", value); }
        ///<summary>Access value of offsetY</summary>
        public double? offsetY
            {
            set { if (!SetDatatypeProperty("offsetY", value)) throw new SetPropertyException("offsetY", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_origin(double[] value) {  return SetDatatypeProperty("origin", value); }
        ///<summary>Access values of origin. OWL cardinality 0..3</summary>
        public double[] origin
            {
            set { if (!SetDatatypeProperty("origin", value)) throw new SetPropertyException("origin", m_instance); }
            get { return GetDatatypeProperty_double("origin"); }
            }
        public bool Set_rotation(double? value) {  return SetDatatypeProperty("rotation", value); }
        ///<summary>Access value of rotation</summary>
        public double? rotation
            {
            set { if (!SetDatatypeProperty("rotation", value)) throw new SetPropertyException("rotation", m_instance); }
            get { var arr = GetDatatypeProperty_double("rotation"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_scalingX(double? value) {  return SetDatatypeProperty("scalingX", value); }
        ///<summary>Access value of scalingX</summary>
        public double? scalingX
            {
            set { if (!SetDatatypeProperty("scalingX", value)) throw new SetPropertyException("scalingX", m_instance); }
            get { var arr = GetDatatypeProperty_double("scalingX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_scalingY(double? value) {  return SetDatatypeProperty("scalingY", value); }
        ///<summary>Access value of scalingY</summary>
        public double? scalingY
            {
            set { if (!SetDatatypeProperty("scalingY", value)) throw new SetPropertyException("scalingY", m_instance); }
            get { var arr = GetDatatypeProperty_double("scalingY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_type(Int64? value) {  return SetDatatypeProperty("type", value); }
        ///<summary>Access value of type</summary>
        public Int64? type
            {
            set { if (!SetDatatypeProperty("type", value)) throw new SetPropertyException("type", m_instance); }
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

        public bool Set_majorRadius(double? value) {  return SetDatatypeProperty("majorRadius", value); }
        ///<summary>Access value of majorRadius</summary>
        public double? majorRadius
            {
            set { if (!SetDatatypeProperty("majorRadius", value)) throw new SetPropertyException("majorRadius", m_instance); }
            get { var arr = GetDatatypeProperty_double("majorRadius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_minorRadius(double? value) {  return SetDatatypeProperty("minorRadius", value); }
        ///<summary>Access value of minorRadius</summary>
        public double? minorRadius
            {
            set { if (!SetDatatypeProperty("minorRadius", value)) throw new SetPropertyException("minorRadius", m_instance); }
            get { var arr = GetDatatypeProperty_double("minorRadius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_majorRadius(double? value) {  return SetDatatypeProperty("majorRadius", value); }
        ///<summary>Access value of majorRadius</summary>
        public double? majorRadius
            {
            set { if (!SetDatatypeProperty("majorRadius", value)) throw new SetPropertyException("majorRadius", m_instance); }
            get { var arr = GetDatatypeProperty_double("majorRadius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_minorRadius(double? value) {  return SetDatatypeProperty("minorRadius", value); }
        ///<summary>Access value of minorRadius</summary>
        public double? minorRadius
            {
            set { if (!SetDatatypeProperty("minorRadius", value)) throw new SetPropertyException("minorRadius", m_instance); }
            get { var arr = GetDatatypeProperty_double("minorRadius"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_matrix(Int64 value) {  return SetObjectProperty("matrix", value); }

        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix matrix
            {
            set
                {
                if (!SetObjectProperty("matrix", value)) throw new SetPropertyException("matrix", m_instance);
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
        public bool Set_object(Int64 value) {  return SetObjectProperty("object", value); }

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                if (!SetObjectProperty("object", value)) throw new SetPropertyException("object", m_instance);
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
        public bool Set_recalculateBBox(bool? value) {  return SetDatatypeProperty("recalculateBBox", value); }
        ///<summary>Access value of recalculateBBox</summary>
        public bool? recalculateBBox
            {
            set { if (!SetDatatypeProperty("recalculateBBox", value)) throw new SetPropertyException("recalculateBBox", m_instance); }
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

        public bool Set_direction(Int64 value) {  return SetObjectProperty("direction", value); }

        ///<summary>Access relationship from this instance to an instance of Vector</summary>
        public Vector direction
            {
            set
                {
                if (!SetObjectProperty("direction", value)) throw new SetPropertyException("direction", m_instance);
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
        public bool Set_length(double? value) {  return SetDatatypeProperty("length", value); }
        ///<summary>Access value of length</summary>
        public double? length
            {
            set { if (!SetDatatypeProperty("length", value)) throw new SetPropertyException("length", m_instance); }
            get { var arr = GetDatatypeProperty_double("length"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_path(Int64 value) {  return SetObjectProperty("path", value); }

        ///<summary>Access relationship from this instance to an instance of Curve</summary>
        public Curve path
            {
            set
                {
                if (!SetObjectProperty("path", value)) throw new SetPropertyException("path", m_instance);
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
        public bool Set_radiusI(double? value) {  return SetDatatypeProperty("radiusI", value); }
        ///<summary>Access value of radiusI</summary>
        public double? radiusI
            {
            set { if (!SetDatatypeProperty("radiusI", value)) throw new SetPropertyException("radiusI", m_instance); }
            get { var arr = GetDatatypeProperty_double("radiusI"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_radiusII(double? value) {  return SetDatatypeProperty("radiusII", value); }
        ///<summary>Access value of radiusII</summary>
        public double? radiusII
            {
            set { if (!SetDatatypeProperty("radiusII", value)) throw new SetPropertyException("radiusII", m_instance); }
            get { var arr = GetDatatypeProperty_double("radiusII"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_segmentationParts(Int64? value) {  return SetDatatypeProperty("segmentationParts", value); }
        ///<summary>Access value of segmentationParts</summary>
        public Int64? segmentationParts
            {
            set { if (!SetDatatypeProperty("segmentationParts", value)) throw new SetPropertyException("segmentationParts", m_instance); }
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

        public bool Set_coordinates(double[] value) {  return SetDatatypeProperty("coordinates", value); }
        ///<summary>Access values of coordinates. OWL cardinality 0..9</summary>
        public double[] coordinates
            {
            set { if (!SetDatatypeProperty("coordinates", value)) throw new SetPropertyException("coordinates", m_instance); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        public bool Set_offsetX(double? value) {  return SetDatatypeProperty("offsetX", value); }
        ///<summary>Access value of offsetX</summary>
        public double? offsetX
            {
            set { if (!SetDatatypeProperty("offsetX", value)) throw new SetPropertyException("offsetX", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetX"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_offsetY(double? value) {  return SetDatatypeProperty("offsetY", value); }
        ///<summary>Access value of offsetY</summary>
        public double? offsetY
            {
            set { if (!SetDatatypeProperty("offsetY", value)) throw new SetPropertyException("offsetY", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetY"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_offsetZ(double? value) {  return SetDatatypeProperty("offsetZ", value); }
        ///<summary>Access value of offsetZ</summary>
        public double? offsetZ
            {
            set { if (!SetDatatypeProperty("offsetZ", value)) throw new SetPropertyException("offsetZ", m_instance); }
            get { var arr = GetDatatypeProperty_double("offsetZ"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_pointReferences(Point[] value) {  return SetObjectProperty("pointReferences", value); }
        public bool Set_pointReferences(Int64[] value) {  return SetObjectProperty("pointReferences", value); }
        ///<summary>Access an array of related instances. OWL cardinality 0..3</summary>
        public Point[] pointReferences
            {
            set
                {
                if (!SetObjectProperty("pointReferences", value)) throw new SetPropertyException("pointReferences", m_instance);
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
                if (!SetObjectProperty("pointReferences", value)) throw new SetPropertyException("pointReferences", m_instance);
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

        public bool Set_innerFraction(double? value) {  return SetDatatypeProperty("innerFraction", value); }
        ///<summary>Access value of innerFraction</summary>
        public double? innerFraction
            {
            set { if (!SetDatatypeProperty("innerFraction", value)) throw new SetPropertyException("innerFraction", m_instance); }
            get { var arr = GetDatatypeProperty_double("innerFraction"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_object(Int64 value) {  return SetObjectProperty("object", value); }

        ///<summary>Access relationship from this instance to an instance of GeometricItem</summary>
        public GeometricItem object_
            {
            set
                {
                if (!SetObjectProperty("object", value)) throw new SetPropertyException("object", m_instance);
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
        public bool Set_outerFraction(double? value) {  return SetDatatypeProperty("outerFraction", value); }
        ///<summary>Access value of outerFraction</summary>
        public double? outerFraction
            {
            set { if (!SetDatatypeProperty("outerFraction", value)) throw new SetPropertyException("outerFraction", m_instance); }
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

        public bool Set_indices(Int64[] value) {  return SetDatatypeProperty("indices", value); }
        ///<summary>Access values of indices. OWL cardinality 0..-1</summary>
        public Int64[] indices
            {
            set { if (!SetDatatypeProperty("indices", value)) throw new SetPropertyException("indices", m_instance); }
            get { return GetDatatypeProperty_Int64("indices"); }
            }
        public bool Set_vertices(double[] value) {  return SetDatatypeProperty("vertices", value); }
        ///<summary>Access values of vertices. OWL cardinality 3..-1</summary>
        public double[] vertices
            {
            set { if (!SetDatatypeProperty("vertices", value)) throw new SetPropertyException("vertices", m_instance); }
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

        public bool Set_coordinates(double[] value) {  return SetDatatypeProperty("coordinates", value); }
        ///<summary>Access values of coordinates. OWL cardinality 0..3</summary>
        public double[] coordinates
            {
            set { if (!SetDatatypeProperty("coordinates", value)) throw new SetPropertyException("coordinates", m_instance); }
            get { return GetDatatypeProperty_double("coordinates"); }
            }
        public bool Set_x(double? value) {  return SetDatatypeProperty("x", value); }
        ///<summary>Access value of x</summary>
        public double? x
            {
            set { if (!SetDatatypeProperty("x", value)) throw new SetPropertyException("x", m_instance); }
            get { var arr = GetDatatypeProperty_double("x"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_y(double? value) {  return SetDatatypeProperty("y", value); }
        ///<summary>Access value of y</summary>
        public double? y
            {
            set { if (!SetDatatypeProperty("y", value)) throw new SetPropertyException("y", m_instance); }
            get { var arr = GetDatatypeProperty_double("y"); return (arr != null && arr.Length > 0) ? (double?)arr[0] : null; }
            }
        public bool Set_z(double? value) {  return SetDatatypeProperty("z", value); }
        ///<summary>Access value of z</summary>
        public double? z
            {
            set { if (!SetDatatypeProperty("z", value)) throw new SetPropertyException("z", m_instance); }
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

        public bool Set_matrix(Int64 value) {  return SetObjectProperty("matrix", value); }

        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix matrix
            {
            set
                {
                if (!SetObjectProperty("matrix", value)) throw new SetPropertyException("matrix", m_instance);
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

        public bool Set_matrix(Int64 value) {  return SetObjectProperty("matrix", value); }

        ///<summary>Access relationship from this instance to an instance of Matrix</summary>
        public Matrix matrix
            {
            set
                {
                if (!SetObjectProperty("matrix", value)) throw new SetPropertyException("matrix", m_instance);
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

