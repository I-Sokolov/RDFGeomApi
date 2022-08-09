
echo Run C# example before this to create CustomModel.bin, and generated wrappers

set ENGINE_INC=O:\DevArea\RDF\GKernel\engine\Code\include
set ENGINE_LIB=O:\DevArea\RDF\a.out\x64\Debug
set OUT_EXE=..\..\bin\Debug\net5.0

mkdir obj
mkdir obj\gcc
del   obj\gcc\* /q

gcc -Wall -Wno-conversion-null -fPIC -DDEBUG -I%ENGINE_INC% -c Program.cpp -o obj\gcc\obj.obj

gcc -o %OUT_EXE%\CustomClassTest.exe obj\gcc\obj.obj %ENGINE_LIB%\engine.lib

pushd %OUT_EXE%

CustomClassTest.exe

popd
pause
