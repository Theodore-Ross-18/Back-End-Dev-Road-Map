# ***Algorithm***

### Algorithms

> The solution to any computing problem involves executing a series of actions in a specific order. 

> A procedure for solving a problem in terms of:

> 1. the actions to be executed, and

> 2. the order in which these actions are to be executed

> is called an ALGORITHM

Example
| Rise and Shine | Algorithm |
|--------------|-----------|
| Get out of bed | Get out of bed |
| Take off pajamas | Take off pajamas |
| Take a shower | Get dressed |
|  Get dressed | Take a shower |
| Eat breakfast | Eat breakfast |
| Go to school | Go to school |

> Specifying the order in which statements are to be executed in a computer program is called program control.

### Pseudocode

> - Is an artificial and informal language that helps programmers develop algorithms.

> - It is similar to everyday English; it is convenient and user-friendly although it is not an actual programming language.

> - It is not executed in computers

> Example: `get the value of A`

https://www.geeksforgeeks.org/how-to-write-a-pseudo-code/

### Flowchart

> - Is a graphical representation of an algorithm or of a portion of an algorithm.

> - Use special-purpose symbols such as rectangles, diamonds, ovals, and small circles etc.

> Is the blueprint of the program

### Basic Symbols used in Flowcharting

---
<svg width="160" height="80" xmlns="http://www.w3.org/2000/svg">
  <ellipse cx="80" cy="40" rx="70" ry="30" stroke="black" fill="white" />
  <text x="50%" y="50%" dominant-baseline="middle" text-anchor="middle">Start/End</text>
</svg>

> `Terminal` - Used to signify the beginning and end of flowchart

---

<svg width="160" height="80" xmlns="http://www.w3.org/2000/svg">
  <rect x="10" y="10" width="140" height="60" rx="15" ry="15" stroke="black" fill="white" />
  <text x="50%" y="50%" dominant-baseline="middle" text-anchor="middle">Initialization</text>
</svg>

> `Initialization` - Indicates the preparation of data, used to select initial condition

---

<svg width="160" height="80" xmlns="http://www.w3.org/2000/svg">
  <polygon points="40,10 130,10 160,40 70,40" stroke="black" fill="white" />
  <text x="58.5" y="25" dominant-baseline="middle" text-anchor="right">Input/Output</text>
</svg>

<svg width="160" height="80" xmlns="http://www.w3.org/2000/svg">
  <rect x="10" y="10" width="140" height="60" stroke="black" fill="white" />
  <text x="50%" y="50%" dominant-baseline="middle" text-anchor="middle">Input/Output</text>
</svg>

> `Input/Output (IO)` - Shows the input and output process

---

<svg width="160" height="80" xmlns="http://www.w3.org/2000/svg">
  <rect x="10" y="10" width="140" height="60" stroke="black" fill="white" />
  <text x="50%" y="50%" dominant-baseline="middle" text-anchor="middle">Process</text>
</svg>

> `Process` - Performs any calculations that are to be done

---

<svg width="160" height="80" xmlns="http://www.w3.org/2000/svg">
  <polygon points="80,10 150,40 80,70 10,40" stroke="black" fill="White" />
  <text x="50%" y="50%" dominant-baseline="middle" text-anchor="middle">Decision</text>
</svg>

> `Decision` - Two alternative execution paths are possible. The path to be followed is selected during the execution by testing whether or not the DECISION condition specified within the outline is fulfilled.

---

<svg width="160" height="80" xmlns="http://www.w3.org/2000/svg">
  <line x1="20" y1="40" x2="120" y2="40" stroke="white" />
  <polygon points="120,40 140,45 140,35" stroke="white" fill="white" />
</svg>

> - `On-Page Connector (Flow Line)` - An on-page connector or flow line is a simple straight line with an arrowhead that connects to other elements and shows the entry or exit point of the flowchart.

> - `Off-Page Connector (Page Reference)` - An off-page connector represents a connection to another page or a different part of the same page, typically with a label indicating the reference of destination or designates entry to or exit from one page when a flowchart requires more than one page.

---

> 1. `Flow Line (Connecting Process Shapes)` - Here's an example of a flow line connecting two process shapes (rectangles):

<svg width="200" height="100" xmlns="http://www.w3.org/2000/svg">
  <rect x="20" y="20" width="160" height="60" rx="15" ry="15" stroke="black" fill="white" />
  <rect x="20" y="120" width="160" height="60" rx="15" ry="15" stroke="black" fill="none" />
  <line x1="100" y1="80" x2="100" y2="120" stroke="white" />
</svg>

*In this SVG, a line connects two process shapes using the coordinates (x1, y1) and (x2, y2).*

> 2. `Flow Line (Connecting Decision and Process Shapes)` - Here's an example of a flow line connecting a decision shape (diamond) and a process shape (rectangle):

<svg width="200" height="100" xmlns="http://www.w3.org/2000/svg">
  <polygon points="100,20 180,50 100,80 20,50" stroke="black" fill="white" />
  <rect x="20" y="120" width="160" height="60" rx="15" ry="15" stroke="black" fill="none" />
  <line x1="100" y1="80" x2="100" y2="120" stroke="white" />
</svg>

*In this SVG, a line connects a decision shape and a process shape.*

---

### Programming

> - Programming is the act or process of planning or writing a program.

> - A `computer program` (also a software program, or just a program) is a sequence of instructions written to perform a specified task for a `computer`.

> - A `programming language` is an artificial language designed to express computations that can be performed by a machine, particularly a computer. 

> Programming languages can be used to create programs that control the behavior of a machine and/or to express algorithms precisely.

### Identifiers

> - Identifiers are the names you supply for variables, types,functions, and labels in your program

> - Identifiers must differ in spelling and case from any keywords. You cannot use keywords as identifiers; they are reserved for special use. You create an identifier by specifying it in the declaration of a variable, type, or function

> - Identifiers are composed of a sequence of letters, digits and the special character _(underscore)

### Keywords

> - `Keyword` - An identifier that you cannot use because it already has a reserved meaning in ~~Java~~ Python.

|  These are the reserved |   keywords   |   you    |  cannot  | used |
|--------------|-----------|------------|------------|------------|
|   abstract  |   default   |  if   |  private   | this |
|  boolean    |   do     |   implements   |  protected  | throw |
|   break  |    double    |   import    |  public   | throws |
|  byte   |   else     |   instanceof   |  return   | transient |
|  case   |   extends  |   int   |  short  | try |
|  catch  |   final   |   interface   |  static  | void |
|   char  |   finally |   long   |  strictfp  | volatile |
|  class  |   float   |   native |  super  | while |
|  const  |   for     |   new    |  switch | continue |
|  goto   |   package |   synchronized   |    | |

### Variables

> - Variables are identifiers that can store a changeable value. These can be different data types (Depends cause a variable can be a constant type where the value is not changeable)

> - Variables is a location in memory where a value can be stored for use by a program

> - We have to declare all variables and constants, before we can use them in our main program.

### Data Types

> - Data type is a data storage format that can contain a specific type or range of values.


|  Name |  Description   |   Size   |  Range  |
|--------------|-----------|------------|------------|
|  char  |   Character or small integer   |  1 byte   |  signed: -128 to 127  - unsigned: 0 to 255|
|  short int (short)  |  Short Integer    |  2 bytes   |  signed: -32768 to 32767 - unsigned: 0 to 65535  |
|  int  |  Integer    |  4 bytes   |  signed: -2147483648 to 2147483647 - unsigned: 0 to 4294967295   |
|  long int (long)  |  Long integer   |   4 bytes  |  signed: -2147483648 to 2147483647  - unsigned: 0 to 4294967295   |
|  bool  |   Boolean Value (True or False)   |  1 byte   |  true or false (0 or 1) - (on or off) |
|  float  |   Floating Point Number   |  4 bytes   |  +/- 3.4e +/- 38 (~7 digits)   |
|  double  |   Double Precision Floating Point Number   |   8 bytes  |  +/-1.7e +/- 308 (~15 digits)   |
|  long double  |   Long Double Precision Floating Point Number   |   8 bytes  |  +/-1.7e +/- 308 (~15 digits)  |


### Rules for defining or naming variables:

> 1. It must consist only letters, digits and underscore: `_total, num_1`

> 2. It should not begin with a digit: `1name, 3to3, 4`

> 3. Keywords are not allowed to be a variable: `float, default`

> 4. It is a case sensitive: `Ans or ans` are two different variable names

> 5. Do not include embedded blanks (white space): `first name`

> 6. Do not call your variable by other name as other functions: `main`

### Variable Declaration

Syntax 
```
Data Type Variable Terminator (;)
```

Example
```
int _total;

float num1, ex_2, file;

char letter;
```

### Operators

> `Operator` is a symbol that tells the computer to perform specific mathematical or logical computations  

#### Three (3) Classes of Operators

#### 1. Arithmetic Operators and Operations

| Operator  | Action  | Sample |
|--------------|-----------|------------|
| `+` |  Addition   |   5 + 3 = 8    |
| `-` |  Subtraction    |   5 - 3 = 2    |
| `*` |  Multiplication   |   5 * 3 = 15     |
| `/` |  Division  |    5 / 3 = 1    |
| `%` |  Modulus   |    5 % 3 = 2    |
| `--` | Decrement 
| `++` | Increment 

#### Concept

> Arithmetic Expressions in Straight-Line Form

> Arithmetic expressions in programming must be written in straight-line form to facilitate entering programs into the computer. Thus, expressions such as “a divided by b” must be written as a/b so that all operators and operands appear in a straight line. The algebraic notation

    Math Expression: a over b

    Programming Expression: a / b

> `Note:` Math expression shown above, is generally not acceptable to compilers, although some special-purpose software packages do support more natural notation for complex mathematical expressions

#### Parentheses for Grouping Sub-expressions

> Parentheses are used in Programming expressions in the same manner as in algebraic expressions.

Example

To multiply a times the quantity b + c we write the following expressions:
```
a * ( b + c )
```

#### Rules of Operator Precedence

> The rules of operator precedence specify the order uses to evaluate expressions

> When we say evaluation proceeds from left to right, we’re referring to the associativity of the operators. We’ll see that some operators associate from right to left.

> Programming applies the operators in arithmetic expressions in a precise sequence determined by the following rules of operator precedence, which are generally the same as those in algebra:

> 1. Operators in expressions contained within pairs of parentheses are evaluated first.Parentheses are said to be at the “highest level of precedence.” In cases of nested, or embedded, parentheses, such as

    ( ( a +b) + c)
the operators in the innermost pair of parentheses are applied first.

> 2. Multiplication, division and remainder operations are applied next. If an expression contains several multiplication, division and remainder operations, evaluation proceeds from left to right. Multiplication, division and remainder are said to be on the same level of precedence.

> 3. Addition and subtraction operations are evaluated next. If an expression contains several addition and subtraction operations, evaluation proceeds from left to right. Addition and subtraction also have the same level of precedence, which is lower than the precedence of the multiplication, division and remainder operations.

> 4. The assignment operator (=) is evaluated last.

| Operator (s) | Operation (s) | Order of Evaluation (precedence) |
|--------------|-----------|------------|
| `( )` | Parentheses | Evaluated first. If the parentheses are nested, the expression in the innermost pair of is evaluated first. If there are several pairs of parentheses `on the same level` and not nested then they're evaluated left to right  |
|   `* / %`   | Multiplication, Division, and Remainder |  Evaluated Second. If there are several, they're evaluated left to right |
|   `+ -`   | Addition and Subtraction  |     |
|   `=`   | Assignment  |   Evaluated last  |

#### PMDRAS (PEMDAS)

> Parenthesis Multiplication Division Remainder Addition Subtraction

> `PEMDAS` is an acronym for Parenthesis, Exponents, Multiplication, Division, Addition, and Subtraction. This is a standard method of determining which operations you must prioritize first, second, third, and so on.

    x = 1 + 0 * 1 – 1 + (6 % 4 / 2)  – division comes first before modulus

    x = 1 + 0 * 1 - 1 + (6 % 2)

    X = 1 + 0 * 1 - 1 + 0

    X = 1 + 0 - 1 + 0 - left to right approach

    X = 1 - 1 + 0 - left to right approach

    X = 0 + 0

    X = 0

#### Converting Mathematical Formula to ~~Java~~ Python Expression

> To solve mathematical problems using the computer, the formula should be translated to the programming language to be used.

Example:
```
b(2) - 4ac ----> b * b - 4 * a * c

a + b / c + d ----> (a + b) / (c + d)

x(3) ----> x * x * x * x
```

#### 2. Relational and Logical Operators (T/F)

| Relational Operators  | Meaning  | Sample |
|--------------|-----------|------------|
| `>` |  Greater Than   |   5 > 3    |
| `>=` | Greater Than or Equal  |   5 >= 5   |
| `<` |  Less Than  |   7 < 10  |
| `<=` |  Less Than or Equal  |    7 <= 9    |
| `==` |  Equal   |    5 == 7    |
| `!=` |  Not Equal  | 5 != 6 |

| Logical Operators  | Meaning  |
|--------------|-----------|
| `&&` |  AND   |
| II | OR  |
| `!` |  NOT  |

#### 3. Bitwise (T(1) / F(0))

> - `OR (||)` at least one of the conditions is true
> - `AND (&&)` two conditions must be true

| A  | B  | A && B | A II B | !A | !B |
|--------------|-----------|-----------|-----------|-----------|-----------|
| 1 | 1 | 1 | 1 | 0 | 0 |
| 1 | 0 | 0 | 1 | 0 | 1 |
| 0 | 1 | 0 | 1 | 1 | 0 |
| 0 | 0 | 0 | 0 | 1 | 1 |