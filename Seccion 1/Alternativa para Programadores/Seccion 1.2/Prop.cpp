#include <stdio.h>
#include <iostream>
#include <string>
#include <map>
#include <vector>
 using namespace std;

typedef map<char, bool> vchar;
typedef vector<bool> vbool;

// Functions
void printFile ();
void userInput ();
void errorDetect ();
void assignVars (int count);
bool operate (char operation, bool op1, bool op2);
void errorMsg (string c);
bool isOperator (char operation);
int exp (int p);
bool isExpr (char prev, char next);
bool negationLoop ();
bool Loop ();
char boolToVF (bool b);
void contingency ();
void confirmQuit ();

// Global variables
string input;
vchar var;
string::iterator strIt;
bool error = 1;
bool started;
bool quit = 0;
vbool result;

int main () {
	printFile ();
	while (!quit) {
		userInput ();
		errorDetect ();
		assignVars (var.size());
		contingency ();
		confirmQuit ();
	}
	return 0;
}

void userInput () {
	cout << "Ingrese una proposici車n: ";
	input = "";
	while (input == "") {
		getline(cin, input);
	}
	cout << endl;
}

void errorDetect () {
	error = 1;
	while (error) {
		error = 0;
		char prev = ' ';
		int bracket = 0;
		bool bf = 0;
		var.clear();
		strIt = input.begin();
		for (int n = 0, e = 0; strIt != input.end(); strIt++) {
			char c = *strIt;
			if (c == ' ') {
				input.erase(strIt--);
			}
			else {
				if (isalpha(c) || isOperator (c)) {
					if (isalpha (c)) {
						var.insert (pair<char, bool>(c, 1));
					}
					if (isExpr(prev, c)) {
						prev = c;
						// si es el 迆ltimo caracter, s赤 o s赤 tiene que ser letra o ')'
						if (&*strIt == &*input.rbegin()) {
							if (!(isalpha(*strIt)) && !(*strIt == ')')) {
								errorMsg ("Error: \"" + string(1, *(input.rbegin())) + "\" no es una expresi車n v芍lida.");
							}
						}
					}
					else {
						errorMsg ("Error: \"" + (prev == '.' ? "" : string(1, prev)) + string(1, c) + "\" no es una expresi車n v芍lida.");
						prev = '.';
					}
					bracket += (c == '(');
					bracket -= (c == ')');
					// missing left bracket
					if (bracket == -1 && bf == 0) {
						bf = 1;
						errorMsg ("Error: faltan par谷ntesis.");
					}
				}
				else {
					errorMsg ("Error: \"" + string(1, c) + "\" no es una expresi車n v芍lida.");
					prev = ' ';
				}
			}
		}
		// missing right bracket
		if (!bf && bracket > 0) {
			errorMsg ("Error: faltan par谷ntesis.");
		}
		if (error) {
			cout << endl;
			userInput ();
		}
	}
}

// 2^n
int exp (int p) {
	int result = 1;
	for (int i = 0; i < p; i++) {
		result *= 2;
	}
	return result;
}

// Asigna valores de verdad a variables con todas las combinaciones posibles
void assignVars (int count) {
	if (count > 0) {
		for (vchar::iterator it = var.begin(); it != var.end(); it++) {
			printf ("%5c", it -> first);
		}
		printf ("%*s\n", input.size() + 4, input.c_str());
		result.clear();
		for (int i = 0; i < exp(count); i++) {
			bool carry = 1;
			for (vchar::reverse_iterator rit = var.rbegin(); rit != var.rend() && carry; rit++) {
				carry = rit -> second ? 1 : 0;
				rit -> second = rit -> second ? 0 : 1;
			}
			for (vchar::iterator it = var.begin(); it != var.end(); it++) {
				printf ("%5c", boolToVF(it -> second));
			}
			// Inicializa el puntero de string
			strIt = input.begin();
			started = 0;
			result.insert (result.begin() + i, Loop());
			printf ("%*c\n", input.size() / 2 + 5, boolToVF(result[i]));
		}
		cout << endl;
	}
	else {
		errorMsg("Error: no es una proposici車n");
	}
}

// Resuelve una proposici車n
bool Loop () {
	bool result = 0;
	char operation = '|';
	if (started) {
		strIt++;
	}
	else {
		started = 1;
	}
	for (; strIt != input.end() && *strIt != ')'; strIt++) {
		if (isalpha(*strIt)) {
			result = operate (operation, result, var[*strIt]);
		}
		else {
			switch (*strIt) {
				case '(':
					result = operate (operation, result, Loop());
					break;
				case '!':
					result = operate (operation, result, negationLoop());
					break;
				default:
					operation = *strIt;
					break;
			}
		}
	}
	return result;
}

// Resuelve la negaci車n de una subproposici車n
bool negationLoop () {
	strIt++;
	if (isalpha(*strIt)) {
		return !(var[*strIt]);
	}
	return !(Loop());
}

// Determina si es tautolog赤a contingencia o contradicci車n
void contingency () {
	vbool::iterator it = result.begin();
	bool first = *(it++);
	while (it != result.end() && first == *it) {
		it++;
	}
	cout << input;
	if (it != result.end()) {
		cout << " es una contingencia.";
	}
	else {
		cout << (first ? " es una tautolog赤a." : " es una contradicci車n.");
	}
	cout << endl;
}

bool operate (char operation, bool op1, bool op2) {
	switch (operation) {
		case '&': return op1 & op2; // AND
		case '|': return op1 | op2; // OR
		case '^': return op1 ^ op2; // XOR
		case '>': return !op1 | op2; // Only if
		case '=': return op1 == op2; // If and Only if
	}
}

bool isOperator (char operation) {
	switch (operation) {
		case '&': return true;
		case '|': return true;
		case '^': return true;
		case '>': return true;
		case '=': return true;
		case '!': return true;
		case '(': return true;
		case ')': return true;
	}
	return false;
}

bool isExpr (char prev, char next) {
	if (isalpha(prev)) {
		return !(next == '(' || next == '!' || isalpha(next));
	}
	switch (prev) {
		case '!': return (next == '(' || isalpha(next));
		case '(': return (next == '!' || next == '(' || isalpha(next));
		case ')': return !(next == '(' || next == '!' || isalpha(next));
		case '.': return true;
	}
	return (next == '(' || next == '!' || isalpha(next));
}

void printFile () {
	FILE * description = fopen ("Descripcion.txt", "r");
	if (description != NULL) {
		char content [50];
		while (fgets (content, 50, description) != NULL) {
			cout << content;
		}
	}
	cout << endl;
	fclose (description);
}

// Confirma salida
void confirmQuit () {
	cout << "1: Continuar\t2: Salir\n";
	int option;
	do {
		cin >> option;
	} while (option != 1 && option != 2);
	quit = option - 1;
}

char boolToVF (bool b) {
	return (b ? 'V' : 'F');
}

void errorMsg (string c) {
	cout << c << '\n';
	error = 1;
}
