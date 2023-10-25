import turtle

# Let us declare our variable for our turtle object
myshape = turtle.Turtle()

# Let us set up a nice screen for our first turtle module
screen = turtle.Screen()
screen.bgcolor("blue")

# Let us change the shape and color of our turtle
myshape.shape("turtle")
myshape.pencolor("gray")

# Use a for loop to repeat the turtle's actions 10 times
for _ in range(10):
    myshape.penup()  # Lift the pen to move without drawing

    # Move forward and write "turtle"
    myshape.goto(0, 0)
    myshape.write("turtle", align="center", font=("Arial", 24, "normal"))
    myshape.forward(90)

    # Move backward and write "turtle"
    myshape.goto(0, 0)
    myshape.write("turtle", align="center", font=("Arial", 24, "normal"))
    myshape.backward(90)

    myshape.pendown()  # Lower the pen to continue drawing

    # Rotate the turtle
    myshape.left(90)  # Turn left by 90 degrees
    myshape.right(90)  # Turn right by 90 degrees

# Close the turtle graphics window when clicked
turtle.exitonclick()