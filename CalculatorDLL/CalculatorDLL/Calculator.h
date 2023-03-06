#pragma once
#ifndef CALCULATOR_H
#define CALCULATOR_H

#ifdef CALCULATOR_EXPORTS
#define CALCULATOR_API __declspec(dllexport)
#else
#define CALCULATOR_API __declspec(dllimport)
#endif

extern "C" CALCULATOR_API int Add(int a, int b);
extern "C" CALCULATOR_API int Subtract(int a, int b);
extern "C" CALCULATOR_API int Multiply(int a, int b);
extern "C" CALCULATOR_API int Divide(int a, int b);

#endif


