# ***Modules***

### What is Module?

> A module is a file consisting of Python code.

> It can define functions, classes, and variables

> Using module allows you to only use the functionality you need when you need it, it keeps your code cleaner.

### Importing Module

Syntax
```
import ModuleName

import Module1, Module2
```

Example
```
import Message

import Math, Calc
```
> In order to use Python Module, you have to import them into a Python program.

### Import Statement

> One way of importing modules is to use import and the name of the module you want to use.

```
import math

print(math.sqrt(16))
print(math.factorial(6))
```

> If we simply do "import math", then `math.sqrt(16)` and math.factorial(6) are required.

> Another way of importing when you only want to import some of the functionality from math module from math import pow.

```
from math import sqrt, factorial

print(math.sqrt(16))
print(math.factorial(6))
```

### Import Module and giving it an alias

> You can create an alias when you import a module, by using the as keyword:

```
import math as m

print(m.sqrt(4))
print(m.factorial(4))
```

### Summary

> - A module is python is the code written inside the file, for example(test.py). Inside your file, you can have your variables, functions, or your class defined.

> - The entire file becomes a module and can be imported inside another file to refer to the code.

> - You can import only a small part of the module, i.e., only the required functions and variable names from the module instead of importing full code.

> - You can also convert the module name to a shorter form by giving an alias name to it. The alias can be done using the keyword.