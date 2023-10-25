# ***Sequence***

### Sequences

> In the real world most of the data that we care about is in the form of sequence or collection. For example, the list of colleges in Palawan State University or a list of your enrolled subjects in the current semester.

> Python provides features to work with lists of all kinds of objects (numbers, words, etc.). The character string is a sequence of individual letters.

---

### Strings

> A string is simply some characters inside quotes. Strings can be defined as a sequential collection of characters; individual characters that make up a string are in particular order from left to right.

Example
```
"Hello World!"

'Palawan State University'
```

> String that contains no characters is called an empty string. It is still considered to be a string and represented by two single or two double quotes with nothing in between (‘’ or “”).

Example
```
" "

` `
```

---

### Lists

> A list is a sequential collection of data values, each value in a list is called elements. Each element in a list is identified by an index. Lists and Strings are similar, they are both collections of characters, but the elements of a list can have different types (int, float, string, etc.) for one list.

To create a new list, enclose the elements in square brackets:
```
[1, 2, 3, 4]

["banana", "apple", "mango"]
```
The list doesn't have to be the same type. For example:
```
["hello", 2.0, 5, [10, 20]]
```

---

### Tuples

> A tuple is like a list, it can be a sequence of items of any type. But instead of using square brackets, tuples are represented using parenthesis

```
ict1 = ("ICT1", "Computer Fundamentals and Programming" 2, "Laboratory", "Wed 8:00-11:00", "NIT 3")
```

> The difference between lists and tuples is that a tuple is immutable, meaning its content can’t be changed after the tuple is created.

### Index Operator: Working with the Characters of a String

> Python uses square brackets to enclose the index to select a single character from a string. The characters in a string are accessed by their position or index value. 

Example: 
 
> “Palawan” has seven characters and it is indexed left to right from position 0 to position 6.

| 0 | 1 | 2 | 3 | 4 | 5 | 6 |
|--------------|-----------|------------|------------|------------|------------|------------|
| P | a | l | a | w | a | n |
| -7 | -6  | -5 | -4 | -3 | -2 | -1 |

> Note: You can also use negative numbers as position or index value where -1 is the rightmost index and so on.

```
school = "Palawan State University"
m = school[2]
print(m)
lastchar = school[-1]
print(lastchar)
```
> The expression school`[2]` selects the character at index 2 from the value of variable school. The letter at index zero of “Palawan State University” is P. So at position `[2]` we have letter l.

### Index Operator: Accessing Elements of a List or Tuple

> Same as in the string, you will use square brackets to access the elements of list or tuple. Remember that indices start at 0, any integer expression can be used as an index. Negative index value will locate items from the right.

```
numbers = [17, 123, 87, 34, 66, 8398, 44]
print(numbers[2])
print(numbers[9-8])
print(numbers[-2])
```

### Length

> The len function returns the number of characters in a string

```
fruit = "Banana"
print(len(fruit))
```

To get the last letter of a string using the len function in the expression.
```
fruit = "Banana"
sz = len(fruit)
lastch = fruit[sz-1]
print(lastch)
```

> Using sz as an index will cause runtime error because there is no letter at index position 6 in “Banana”, since indexing starts counting at zero. To get the last character, you have to subtract 1 from the length.

Typically, you can combine lines 2 and 3 to a single line statement.
```
lastch = fruit[len(fruit)-1]
```
You can also use the len function to access the middle character of the string.
```
fruit = "grape"
midchar = fruit[len(fruit)//2]
```
When the len function is used in a list it will return the number of items in the list.
```
alist = ["hello", 2.0, 5]
print(len(alist))
print(len(alist[0]))
```

### The Slice Operator

> A substring of a string is called a `slice`. Selecting a slice is similar to selecting a character.

```
print(singers[0:5])
print(singers[7:11])
print(singers[17:21])
```

> The slice operator `[n:m]` returns part of the string starting with a character at index n and going up to but not including the character at index m

> If you omit the first index (n) before the colon, the slice starts at the beginning of the string. If you omit the second index (m) the slice goes to the end of the string.

```
fruit = "banana"
print(fruit[:3])
print(fruit[3:])

```

### List Slices

> The slice operation used in a string will work on list elements too.

```
a_list = ['a', 'b', 'c', 'd', 'e', 'f']
print(a_list[1:3])
print(a_list[:4])
print(a_list[3:])
print(a_list[:])
```

### Tuple Slices

> You can’t modify the elements of a tuple, but you can make a variable reference a new tuple holding different values.

```
julia = ("Julia", "Roberts", 1967, "Duplicity", 2009, "Actress", "Atlanta, Georgia")

print(julia[2])
print(julia[2:6])
print(len(julia))
julia = julia[:3] + ("Eat Pray Love", 2010) + julia[5:]

print(julia)
```

### Concatenation and Repetition

> The + operator concatenates the lists same as with the strings. The * operator repeats the items in a list given the number of times.

```
fruit = ["apple","orange","banana","cherry"]

print([1,2] + [3,4])
print(fruit+[6,7,8,9])
print([0] * 4)
```

> When newlist is created by the statement `newlist` = `fruit` + `numlist`, it is a completely new list formed by making copies of the items from `fruit` and `numlist`.

### Count

> To use the count method, you need to provide one argument, which is what you want to count. This method will return the number of times that the argument occurred in the string/list.

```
a = "I have had an apple on my desk before!"

print(a.count("e"))
print(a.count("ha"))
```

> The statement print(a.count("e")) will return the number of occurrences of “e” in “I have had an apple on my desk before!”

```
z = ['atoms', 4, 'neutron', 6, 'proton', 4, 'electron', 4, 'electron', 'atoms']

print(z.count("4"))
print(z.count(4))
print(z.count("a"))
print(z.count("electron"))
```

> Why do you think print(z.count("4")) and print(z.count("a")) returns 0? This is because the list z only contains integer 4, there are no strings that are 4. And though some words contain “a” like atoms, the program is looking for items in the list that are just the letter “a”.

### Index

> Like the count method, the index method requires one argument. For both strings and list, index returns the leftmost index where the argument is found.

```
music = "Pull out your music and dancing can begin"

bio = ["Metatarsal", "Metatarsal", "Fibula", [], "Tibia", "Tibia", 43, "Femur", "Occipital", "Metatarsal"]

print(music.index("m"))
print(music.index("your"))
print(bio.index("Metatarsal"))
print(bio.index([]))
print(bio.index(43))
```

> The “`Metatarsal`” appears three times in the list bio and the statement `print(bio.index("Metatarsal"))` returns 0. 

Why is that? 

> Even though “`Metatarsal`” occurs many times, the method will only return the location of one of them, that is the leftmost index.

An error will occur if the argument is not in the string or list. Try to run this example.
```
seasons = ["winter", "spring", "summer", "fall"]

print(seasons.index("autumn")) #Error!
```

### Splitting and Joining Strings

### Split

> The `split` method breaks a string into a list of words. White-spaces is considered a word boundary.

```
song = "The rain in Spain..."
wds = song.split()
print(wds)
```
You can use an optional argument, it is called delimiter. It is used to specify which characters to use as word boundaries. The following example uses the string ‘ai’ as the delimiter.
```
song = "The rain in Spain..."
wds = song.split('ai')
print(wds)
```

### Join

> You choose the desired separator string (often called glue) and join the list with the glue between each of the elements

```
wds = ["red", "blue", "green"]
glue = ';'
s = glue.join(wds)

print(s)
print(wds)
print("***".join(wds))
print("".join(wds))
```

> After the execution of the statement `s = glue.join(wds)` the value of `s` will be red;blue;green. 

> Every item in the `list` wds will be joined separated by ‘;’ which is the value of `glue`.


