# ***Browsers***

> A web browser is a software application that enables a user to access and display web pages or other online content through its graphical user interface.

## How browsers work

### Introduction

> Web browsers are the most widely used software. In this primer, I will explain how they work behind the scenes. We will see what happens when you type `google.com` in the address bar until you see the Google page on the browser screen.

### The browser's main functionality

> The main function of a browser is to present the web resource you choose, by requesting it from the server and displaying it in the browser window. The resource is usually an HTML document, but may also be a PDF, image, or some other type of content. The location of the resource is specified by the user using a URI (Uniform Resource Identifier).

> The way the browser interprets and displays HTML files is specified in the HTML and CSS specifications. These specifications are maintained by the W3C (World Wide Web Consortium) organization, which is the standards organization for the web. For years browsers conformed to only a part of the specifications and developed their own extensions. That caused serious compatibility issues for web authors. Today most of the browsers more or less conform to the specifications.

Browser user interfaces have a lot in common with each other. Among the common user interface elements are:

> - Address bar for inserting a URI

> - Back and forward buttons

> - Bookmarking options

> - Refresh and stop buttons for refreshing or stopping the loading of current documents

> - Home button that takes you to your home page

> Strangely enough, the browser's user interface is not specified in any formal specification, it just comes from good practices shaped over years of experience and by browsers imitating each other. The HTML5 specification doesn't define UI elements a browser must have, but lists some common elements. Among those are the address bar, status bar and tool bar. There are, of course, features unique to a specific browser like Firefox's downloads manager.

### The browser's high level structure

The browser's main components are:

> 1. `The user interface:` this includes the address bar, back/forward button, bookmarking menu, etc. Every part of the browser display except the window where you see the requested page.

> 2. `The browser engine:` marshals actions between the UI and the rendering engine.

> 3. `The rendering engine:` responsible for displaying requested content. For example if the requested content is HTML, the rendering engine parses HTML and CSS, and displays the parsed content on the screen.

> 4. `Networking:` for network calls such as HTTP requests, using different implementations for different platform behind a platform-independent interface.

> 5. `UI backend:` used for drawing basic widgets like combo boxes and windows. This backend exposes a generic interface that is not platform specific. Underneath it uses operating system user interface methods.

> 6. `JavaScript interpreter:` Used to parse and execute JavaScript code.

> 7. `Data storage:` This is a persistence layer. The browser may need to save all sorts of data locally, such as cookies. Browsers also support storage mechanisms such as localStorage, IndexedDB, WebSQL and FileSystem.

- [Browser Components](https://web.dev/static/articles/howbrowserswork/image/browser-components-9cd8ff834cc9c_856.png)

> It is important to note that browsers such as Chrome run multiple instances of the rendering engine: one for each tab. Each tab runs in a separate process.

### The rendering engine

> The responsibility of the rendering engine is well… Rendering, that is display of the requested contents on the browser screen.

> By default the rendering engine can display HTML and XML documents and images. It can display other types of data via plug-ins or extension; for example, displaying PDF documents using a PDF viewer plug-in. However, in this chapter we will focus on the main use case: displaying HTML and images that are formatted using CSS.

### Rendering engines

> Different browsers use different rendering engines: Internet Explorer uses Trident, Firefox uses Gecko, Safari uses WebKit. Chrome and Opera (from version 15) use Blink, a fork of WebKit.

> WebKit is an open source rendering engine which started as an engine for the Linux platform and was modified by Apple to support Mac and Windows. See webkit.org for more details.

### The main flow

> The rendering engine will start getting the contents of the requested document from the networking layer. This will usually be done in 8kB chunks.

After that, this is the basic flow of the rendering engine:

- [Rendering Engine Basic Flow](https://web.dev/static/articles/howbrowserswork/image/rendering-engine-basic-fl-2fba02b24e871_856.png)

> The rendering engine will start parsing the HTML document and convert elements to DOM nodes in a tree called the "content tree". The engine will parse the style data, both in external CSS files and in style elements. Styling information together with visual instructions in the HTML will be used to create another tree: the render tree.

> The render tree contains rectangles with visual attributes like color and dimensions. The rectangles are in the right order to be displayed on the screen.

> After the construction of the render tree it goes through a "layout" process. This means giving each node the exact coordinates where it should appear on the screen. The next stage is painting - the render tree will be traversed and each node will be painted using the UI backend layer.

> It's important to understand that this is a gradual process. For better user experience, the rendering engine will try to display contents on the screen as soon as possible. It will not wait until all HTML is parsed before starting to build and layout the render tree. Parts of the content will be parsed and displayed, while the process continues with the rest of the contents that keeps coming from the network.

Main Flow Example

- [WebKit main flow](https://web.dev/static/articles/howbrowserswork/image/webkit-main-flow-b779d50c0cf28_856.png)

- [Mozilla's Gecko Rendering Engine Main Flow](https://web.dev/static/articles/howbrowserswork/image/mozillas-gecko-rendering-b18e445544965_856.jpg)

> From figures 3 and 4 you can see that although WebKit and Gecko use slightly different terminology, the flow is basically the same.

> Gecko calls the tree of visually formatted elements a "Frame tree". Each element is a frame. WebKit uses the term "Render Tree" and it consists of "Render Objects". WebKit uses the term "layout" for the placing of elements, while Gecko calls it "Reflow". "Attachment" is WebKit's term for connecting DOM nodes and visual information to create the render tree. A minor non-semantic difference is that Gecko has an extra layer between the HTML and the DOM tree. It is called the "content sink" and is a factory for making DOM elements. We will talk about each part of the flow:

### Parsing - general

> Since parsing is a very significant process within the rendering engine, we will go into it a little more deeply. Let's begin with a little introduction about parsing.

> Parsing a document means translating it to a structure the code can use. The result of parsing is usually a tree of nodes that represent the structure of the document. This is called a parse tree or a syntax tree.

For example, parsing the expression `2 + 3 - 1` could return this tree:

- [Mathematical Expression Tree Node](https://web.dev/static/articles/howbrowserswork/image/mathematical-expression-t-6681a2511ead2_856.png)

### Grammars

> Parsing is based on the syntax rules the document obeys: the language or format it was written in. Every format you can parse must have deterministic grammar consisting of vocabulary and syntax rules. It is called a context free grammar. Human languages are not such languages and therefore cannot be parsed with conventional parsing techniques.

### Parser - Lexer combination

> Parsing can be separated into two sub processes: lexical analysis and syntax analysis.

> Lexical analysis is the process of breaking the input into tokens. Tokens are the language vocabulary: the collection of valid building blocks. In human language it will consist of all the words that appear in the dictionary for that language.

> Syntax analysis is the applying of the language syntax rules.

> Parsers usually divide the work between two components: the `lexer` (sometimes called tokenizer) that is responsible for breaking the input into valid tokens, and the `parser` that is responsible for constructing the parse tree by analyzing the document structure according to the language syntax rules.

The lexer knows how to strip irrelevant characters like white spaces and line breaks.

- [From Source Document to Parse Trees](https://web.dev/static/articles/howbrowserswork/image/from-source-document-par-c9c8c59da1ef2_856.png)

> The parsing process is iterative. The parser will usually ask the lexer for a new token and try to match the token with one of the syntax rules. If a rule is matched, a node corresponding to the token will be added to the parse tree and the parser will ask for another token.

> If no rule matches, the parser will store the token internally, and keep asking for tokens until a rule matching all the internally stored tokens is found. If no rule is found then the parser will raise an exception. This means the document was not valid and contained syntax errors.

### Translation

> In many cases the parse tree is not the final product. Parsing is often used in translation: transforming the input document to another format. An example is compilation. The compiler that compiles source code into machine code first parses it into a parse tree and then translates the tree into a machine code document.

- [Compilation Flow](https://web.dev/static/articles/howbrowserswork/image/compilation-flow-57cfc3aa68a53_856.png)

### Parsing example

> In figure 5 we built a parse tree from a mathematical expression. Let's try to define a simple mathematical language and see the parse process.

> `Key term:` Our language can include integers, plus signs and minus signs.

Syntax:
```
1. The language syntax building blocks are expressions, terms and operations.

2. Our language can include any number of expressions.

3. An expression is defined as a "term" followed by an "operation" followed by another term

4. An operation is a plus token or a minus token

5. A term is an integer token or an expression

```

# Let's analyze the input `2 + 3 - 1`.

> 1. `The first substring that matches a rule is 2: according to rule #5 it is a term.`

> 2. `The second match is 2 + 3: this matches the third rule: a term followed by an operation followed by another term.`

> 3. `The next match will only be hit at the end of the input. 2 + 3 - 1 is an expression because we already know that 2 + 3 is a term, so we have a term followed by an operation followed by another term. 2 + + will not match any rule and therefore is an invalid input.`

### Formal definitions for vocabulary and syntax

> Vocabulary is usually expressed by regular expressions.

For example our language will be defined as:

```
INTEGER: 0|[1-9][0-9]*
PLUS: +
MINUS: -
```

> As you see, integers are defined by a regular expression.

Syntax is usually defined in a format called `BNF`. Our language will be defined as:

```
expression :=  term  operation  term
operation :=  PLUS | MINUS
term := INTEGER | expression
```

> We said that a language can be parsed by regular parsers if its grammar is a context free grammar. An intuitive definition of a context free grammar is a grammar that can be entirely expressed in BNF.

For a formal definition see:
- [Wikipedia's Article on Context-Free Grammar](http://en.wikipedia.org/wiki/Context-free_grammar)

### Types of parsers


















