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





