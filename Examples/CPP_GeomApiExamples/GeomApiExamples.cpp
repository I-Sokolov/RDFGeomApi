// CPP_GeometryKernel.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <stdio.h>
#include <math.h>
#include <string.h>
#include <assert.h>
#include <list>

#include "engine.h"
#include "geom.h"
using namespace GEOM;

#include "..\..\EngineEx_Template.h" //to check compilable

static void ASSERT_AT(bool c, const char* cond, const char* file, int line)
{
	if (!c)
		printf("!!!!  ASSERT %s VIOLATED at file %s line %d\n", cond, file, line);
	assert(c);
}
#define ASSERT(c) ASSERT_AT((c), #c, __FILE__, __LINE__);
#define ASSERT_ARR_EQ(r1,r2,N)  	for (int i=0; i<N; i++) { ASSERT_AT((fabs ((double)r1[i]-(double)r2[i]) < 1e-9), #r1 "!=" #r2, __FILE__, __LINE__);}

static int64_t CreateRedBox(int64_t model);
static void MoreExamplesToAccessDifferentTypesOfProperties(int64_t model);


/// <summary>
/// 
/// </summary>
/// <returns></returns>
int main()
{
	int64_t model = OpenModel((char*)NULL);

	CreateRedBox(model);

	MoreExamplesToAccessDifferentTypesOfProperties(model);

	CloseModel(model);

	printf("\ntest finsihed\n");
}


/// <summary>
/// 
/// </summary>
/// <param name="model"></param>
/// <returns></returns>
static int64_t CreateRedBox(int64_t model)
{
	//
	// create colored material
	//

	ColorComponent colorComponent = ColorComponent::Create(model);
	colorComponent.set_R(0.9);
	colorComponent.set_G(0);
	colorComponent.set_B(0);

	//you can use instance and property handlers API
	int64_t propW = GetPropertyByName(model, "W");
	double w = 0.5;
	SetDatatypeProperty(colorComponent, propW, &w, 1);
	//the code above is equivalent to
	colorComponent.set_W(0.5);

	//or you easy use existing instance handlers with classes
	int64_t colorClass = GetClassByName(model, "Color");
	int64_t colorInstance = CreateInstance(colorClass);

	//get wrapper object from instance handler
	Color color(colorInstance);
	color.set_ambient(colorComponent);

	Material material = Material::Create(model);
	material.set_color(color);

	//
	Box box = Box::Create(model);

	box.set_height(3);
	box.set_width(2);
	box.set_length(4);
	box.set_material(material);  //set_material is inherited from GeometricItem

	return box;
}


/// <summary>
/// 
/// </summary>
/// <param name=""></param>
static void MoreExamplesToAccessDifferentTypesOfProperties(int64_t model)
{
	//teste to set/get different property types

	Texture texture = Texture::Create(model, "my texture");
	NURBSCurve curve = NURBSCurve::CreateW(model, L"my curve");

	//
	ASSERT(0 == strcmp(GetNameOfInstance(texture), "my texture"));
	ASSERT(0 == wcscmp(GetNameOfInstanceW(texture), L"my texture"));	
	ASSERT(0 == strcmp(GetNameOfInstance(curve), "my curve"));
	ASSERT(0 == wcscmp(GetNameOfInstanceW(curve), L"my curve"));

	//cast check
	int64_t texture_id = texture;
	int64_t curve_id = curve;

	GeometricItem geometricItem (curve_id);   //use either id or wrapper
	ASSERT(geometricItem != 0);

	GeometricItem notGeometricItem (texture);
	ASSERT(notGeometricItem == 0);

	ASSERT((GeometricItem) curve != 0);
	ASSERT((GeometricItem) texture == 0);

	ASSERT((GeometricItem) curve_id != 0);
	ASSERT((GeometricItem) texture_id == 0);


	//double
	const double* lseg = curve.get_segmentationLength();
	ASSERT(lseg == NULL);
	auto ok = curve.set_segmentationLength(0.5);
	ASSERT(ok);
	lseg = curve.get_segmentationLength();
	ASSERT(*lseg == 0.5);

	//double []
	int64_t cnt;
	const double* org = texture.get_origin(&cnt);
	ASSERT(org == NULL);
	double orgset[] = {1, 2, 3};
	ok = texture.set_origin(orgset, 3);
	ASSERT(ok);
	org = texture.get_origin(&cnt);
	ASSERT(cnt == 3);
	ASSERT_ARR_EQ(org, orgset, cnt);

	//enumerable templates
	std::list<int> coords;
	coords.push_back(1);
	coords.push_back(3);
	coords.push_back(7);

	auto pointSet = Point3DSet::Create(model);
	pointSet.set_coordinates(coords);

	cnt = 0;
	const double* rd = pointSet.get_coordinates(&cnt);
	ASSERT(cnt = 3 && rd[0] == 1 && rd[1] == 3 && rd[2] == 7);


	//there is ability to identity property by name
	orgset[1] = 10;
	ok = texture.SetDatatypeProperty<double>("origin", orgset, 3);
	ASSERT(ok);
	org = texture.GetDatatypeProperty<double>("origin", &cnt);
	ASSERT_ARR_EQ(org, orgset, cnt);

	//cardinality restriction violation
	double tooLong[] = { 1, 2, 3, 4 };
	ok = texture.set_origin(tooLong, 4);
	ASSERT(!ok);

	// wrong property name
	ok = texture.SetDatatypeProperty<double>("length", org, 3);
	ASSERT(!ok);
	ok = texture.GetDatatypeProperty<double>("originnn", &cnt);
	ASSERT(!ok);


	//int64_t
	const int64_t* setting = curve.get_setting();
	ASSERT(setting == NULL);
	ok = curve.set_setting(13);
	ASSERT(ok);
	setting = curve.get_setting();
	ASSERT(*setting == 13);

	//int64_t[]
	const int64_t* km = curve.get_knotMultiplicities(&cnt);
	ASSERT(km == NULL);
	int64_t kmset[] = {3, 5, 6};
	ok = curve.set_knotMultiplicities(kmset, 3);
	ASSERT(ok);
	km = curve.get_knotMultiplicities(&cnt);
	ASSERT(cnt == 3);
	ASSERT_ARR_EQ(km, kmset, cnt);

	//string 
	const char* const* tname = texture.get_name();
	ASSERT(tname == NULL);
	ok = texture.set_name("test");
	ASSERT(ok);
	tname = texture.get_name();
	ASSERT(0 == strcmp(*tname, "test"));

	//string[]
	//no example in Geometry Kernel

	//bool
	const bool* closed = curve.get_closed();
	ASSERT(closed == NULL);
	curve.set_closed(true);
	closed = curve.get_closed();
	ASSERT(closed && *closed);

	//bool[]
	//no example in Geometry Kernel

	//object
	const Material* material = curve.get_material();
	ASSERT(material == NULL);
	int64_t mat = Material::Create(model);
	curve.set_material(Material(mat));
	material = curve.get_material();
	ASSERT(*material == mat);
	const Material* m2 = curve.get_material();
	ASSERT(*m2 == *material);

	//object []
	const Point3D* ptg = curve.get_controlPoints(&cnt);
	ASSERT(ptg == NULL);
	const int64_t* ptg64 = curve.get_controlPoints_int64(&cnt);
	ASSERT(ptg64 == NULL);

	Point3D pts[] = {Point3D::Create(model), Point3D::Create(model)};
	ASSERT(pts[0] != pts[1]);

	curve.set_controlPoints(pts, 2);

	ptg = curve.get_controlPoints(&cnt);
	ASSERT(cnt == 2);
	for (int i = 0; i < cnt; i++) ASSERT(pts[i] == ptg[i]);
	ASSERT_ARR_EQ(ptg, pts, cnt);

	ptg64 = curve.get_controlPoints_int64(&cnt);
	ASSERT(cnt == 2);
	for (int i = 0; i < cnt; i++) ASSERT(pts[i] == ptg64[i]);
	ASSERT_ARR_EQ(ptg64, pts, cnt);
}
