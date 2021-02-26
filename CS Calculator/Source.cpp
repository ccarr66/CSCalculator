#include <iostream> // allows program to perform input and output
#include <Windows.h>

using std::cout; // program uses cout
using std::cin; // program uses cin
using std::endl; // program uses endl

long double factorial(long double, long double);
long double exponent(long double, int);
long double taylorSeriesAeX(long double, long double);
long double taylorSeriesLnX(long double);
bool checkLnTerm(long double);
long double absV(long double);
int evenOrOdd(long double);




void main()
{
	while (true)
	{
		cout << "Enter base" << endl;
		long double base;
		cin >> base;
		cout << "Enter exponent" << endl;
		long double exponent;
		cin >> exponent;
		long double answer = taylorSeriesAeX(exponent, base);
		if (base < 0)
		{
			if (exponent - (int)exponent != 0)
				cout << "To compensate for mathematical limitations of approximation method answer will be positive for fractional exponents" << endl;
			answer *= evenOrOdd(exponent);
		}
		cout << "a^x = " << answer << "\n\n" << endl;
		//long double error = base - taylorSeriesAeX((1 / exponent), answer);
		//cout << "error = " << absV(error) << endl;
	}
	Sleep(1000 * 1000);

}


long double exponent(long double n, int r)
{
	if (r == 0)
		return 1;
	if (r < 0)
		n = 1 / n;
	long double answer = n;
	int level = 1;
	while (level < r)
	{
		answer = answer * n;
		level++;
	}
	return answer;
}

long double taylorSeriesLnX(long double x)
{
	long double sum = 0;
	int k = 1;

	x = (1 / absV(x)) - 1;

	long double term = ((exponent(-1, k + 1))*(exponent(x, k))) / k;

	while (checkLnTerm(term))
	{
		//		cout << "k: " << sum << endl;

		sum = sum + term;
		k++;
		term = ((exponent(-1, k + 1))*(exponent(x, k))) / k;
		//		cout << "k: " << k << "   term: " << term << "   sum: " << sum << endl;

	}
	//	cout << k << endl;
	return -sum;

}

bool checkLnTerm(long double term)
{
	if (term > 0)
	{
		if (term > 0.00000001)
			return true;
		else
			return false;
	}
	else if (term < 0)
	{
		if (term < -0.00000001)
			return true;
		else
			return false;
	}
	else
		return false;
}

long double taylorSeriesAeX(long double exp, long double base)
{
	long double sum = 1;
	int term = 1;
	long double  lnx = taylorSeriesLnX(base);


	//	cout << "\n\nterm" << term << " " << (exponent(exp, term) / (long double)factorial(term, term)) << endl;
	//	cout << "sum: " << sum << endl;
	//	cout << "numerator: " << exponent(exp, term) << "   denominator: " << (long double)factorial(term, term) << endl;


	while (/*term < 1000 && */ isnormal(((exponent(exp, term) * exponent(lnx, term)))) && isnormal((long double)factorial(term, term)))
	{
		//		cout << "\n\nterm" << term << " " << ((exponent(exp, term) * exponent(lnx, term)) / (long double)factorial(term, term)) << endl;
		//		cout << "numerator: " << exponent(exp, term) << " * " << exponent(lnx, term) << "   denominator: " << (long double)factorial(term, term) << endl;
		sum = sum + ((exponent(exp, term)) * (exponent(lnx, term) / (long double)factorial(term, term)));
		//		cout << "sum: " << sum << endl;
		term++;

	}
	return sum;

}

long double factorial(long double n, long double answer)
{
	if (n > 1)
	{
		answer = answer * (n - 1);
		answer = factorial(--n, answer);
	}
	return answer;
}

long double absV(long double n)
{
	if (n < 0)
		n *= (-1);
	return n;
}

int evenOrOdd(long double exp)
{
	if (exp - (int)exp == 0)
	{
		if ((int)exp % 2 != 0)
			return -1;
		else
			return 1;
	}
	else
		return 1;
}



/*
float recRoot(float n, int root)
{
int ansCount = 0;
float N = n;

cout << ansCount << ": " <<  n << endl;
ansCount++;

float answer;
/*if (n<1 && n>-1)
answer = ((float)n) * root;
else*
answer = ((float)n) / root;

cout << ansCount << ": " << answer << endl;
ansCount++;

cout << "--1" << answer << "  " << root << "  " << n << endl;
cout << "--2" << (exponent(answer, root) - n) << endl;

int DEBUGLOOPCTRL = 0;
while (DEBUGLOOPCTRL < 90 && !(((exponent(answer, root) - n) < .0001) && ((exponent(answer, root) - n) > -.0001)))		//error should be ok
{
answer = answer - ( ((exponent(answer, root)) - N) / (root * (exponent(answer, root - 1))));		//error should be ok
cout << ansCount << ": " << answer << endl;
ansCount++;
DEBUGLOOPCTRL++;
}
return answer;
}

int findWholeDecimal(float n, int* degree)
{
int N = (int)n;																		//error should be ok
int count = 0;
while (n-N != 0)
{
n = 10*n;
N = (int)n;																		//error should be ok
count++;
}
*degree = (int)exponent(10, count);
//cout << *degree << endl;
return (int)n;																		//error should be ok
}
*/


/*int EXPVALUE = (int)expValue;
cout << "expValue " << expValue << "  " << "EXPVALUE " << EXPVALUE << endl;


if (expValue - EXPVALUE != 0)
{
float expRemainder = expValue - EXPVALUE;
cout << "expRemainder " << expRemainder << endl;
int degree = 0;
expValue = (float)findWholeDecimal(expRemainder, &degree);						//error should be ok
cout << "expValue1 " << expValue << "  degree " << degree << endl;
float answer;
//if (expValue < degree)
//answer = recRoot(exponent(numberToExp,(int)expValue),degree);
//else
answer = exponent(recRoot(numberToExp,degree),(int)expValue);			//error should be ok
cout << answer << endl;
}
else
cout << exponent(numberToExp, (int)expValue) << endl;						//error should be ok		*/