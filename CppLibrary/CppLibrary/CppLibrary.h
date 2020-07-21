#pragma once

#ifdef CPPLIBRARY_EXPORTS
#define CPPLIBRARY_API __declspec(dllexport)
#else
#define CPPLIBRARY_API __declspec(dllimport)
#endif

// Adds the two numbers
extern "C" CPPLIBRARY_API int add(int a, int b);

//Multiples the two numbers
extern "C" CPPLIBRARY_API int mul(int a, int b);