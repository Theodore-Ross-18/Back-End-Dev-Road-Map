# ***Python: Turtle***

> In Python, "turtles" typically refer to the Turtle graphics library, which is a part of the Python Standard Library. Turtle graphics is a popular way to introduce programming to beginners, especially children. It provides a simple and interactive way to draw shapes and create basic graphics using a virtual "turtle" that moves around the screen.

> The Turtle graphics library is based on the concept of a turtle that can move forward, backward, turn left or right, and draw on the screen as it moves. You can control this turtle using a set of simple commands. For example, you can use commands like `forward()`, `backward()`, `left()`, and `right()` to control the turtle's movement, and you can use `penup()` and `pendown()` to control whether the turtle leaves a trail as it moves.

Here's a very simple example of how to use the Turtle graphics library to draw a square:
```
import turtle

# Create a Turtle screen and a Turtle object
window = turtle.Screen()
pen = turtle.Turtle()

# Use the Turtle to draw a square
for _ in range(4):
    pen.forward(100)  # Move forward by 100 units
    pen.right(90)     # Turn right by 90 degrees

# Close the Turtle graphics window on click
window.exitonclick()

```

> This code creates a window with a turtle that draws a square. You can experiment with different commands and patterns to create more complex drawings and designs.

> Turtle graphics can be a fun way to learn programming concepts like loops, conditionals, and basic geometry. It's often used as an educational tool to teach the fundamentals of programming in a visual and interactive manner.