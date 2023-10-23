# ***Browsers***

> A web browser is a software application that enables a user to access and display web pages or other online content through its graphical user interface.

# How browsers work

## Introduction

> Web browsers are the most widely used software. In this primer, I will explain how they work behind the scenes. We will see what happens when you type `google.com` in the address bar until you see the Google page on the browser screen.

## The browser's main functionality

> The main function of a browser is to present the web resource you choose, by requesting it from the server and displaying it in the browser window. The resource is usually an HTML document, but may also be a PDF, image, or some other type of content. The location of the resource is specified by the user using a URI (Uniform Resource Identifier).

> The way the browser interprets and displays HTML files is specified in the HTML and CSS specifications. These specifications are maintained by the W3C (World Wide Web Consortium) organization, which is the standards organization for the web. For years browsers conformed to only a part of the specifications and developed their own extensions. That caused serious compatibility issues for web authors. Today most of the browsers more or less conform to the specifications.

Browser user interfaces have a lot in common with each other. Among the common user interface elements are:

> - Address bar for inserting a URI

> - Back and forward buttons

> - Bookmarking options

> - Refresh and stop buttons for refreshing or stopping the loading of current documents

> - Home button that takes you to your home page

> Strangely enough, the browser's user interface is not specified in any formal specification, it just comes from good practices shaped over years of experience and by browsers imitating each other. The HTML5 specification doesn't define UI elements a browser must have, but lists some common elements. Among those are the address bar, status bar and tool bar. There are, of course, features unique to a specific browser like Firefox's downloads manager.

## The browser's high level structure

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

## The rendering engine

> The responsibility of the rendering engine is well… Rendering, that is display of the requested contents on the browser screen.

> By default the rendering engine can display HTML and XML documents and images. It can display other types of data via plug-ins or extension; for example, displaying PDF documents using a PDF viewer plug-in. However, in this chapter we will focus on the main use case: displaying HTML and images that are formatted using CSS.

## Rendering engines

> Different browsers use different rendering engines: Internet Explorer uses Trident, Firefox uses Gecko, Safari uses WebKit. Chrome and Opera (from version 15) use Blink, a fork of WebKit.

> WebKit is an open source rendering engine which started as an engine for the Linux platform and was modified by Apple to support Mac and Windows. See webkit.org for more details.

## The main flow

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

## Parsing - general

> Since parsing is a very significant process within the rendering engine, we will go into it a little more deeply. Let's begin with a little introduction about parsing.

> Parsing a document means translating it to a structure the code can use. The result of parsing is usually a tree of nodes that represent the structure of the document. This is called a parse tree or a syntax tree.

For example, parsing the expression `2 + 3 - 1` could return this tree:

- [Mathematical Expression Tree Node](https://web.dev/static/articles/howbrowserswork/image/mathematical-expression-t-6681a2511ead2_856.png)

## Grammars

> Parsing is based on the syntax rules the document obeys: the language or format it was written in. Every format you can parse must have deterministic grammar consisting of vocabulary and syntax rules. It is called a context free grammar. Human languages are not such languages and therefore cannot be parsed with conventional parsing techniques.

## Parser - Lexer combination

> Parsing can be separated into two sub processes: lexical analysis and syntax analysis.

> Lexical analysis is the process of breaking the input into tokens. Tokens are the language vocabulary: the collection of valid building blocks. In human language it will consist of all the words that appear in the dictionary for that language.

> Syntax analysis is the applying of the language syntax rules.

> Parsers usually divide the work between two components: the `lexer` (sometimes called tokenizer) that is responsible for breaking the input into valid tokens, and the `parser` that is responsible for constructing the parse tree by analyzing the document structure according to the language syntax rules.

The lexer knows how to strip irrelevant characters like white spaces and line breaks.

- [From Source Document to Parse Trees](https://web.dev/static/articles/howbrowserswork/image/from-source-document-par-c9c8c59da1ef2_856.png)

> The parsing process is iterative. The parser will usually ask the lexer for a new token and try to match the token with one of the syntax rules. If a rule is matched, a node corresponding to the token will be added to the parse tree and the parser will ask for another token.

> If no rule matches, the parser will store the token internally, and keep asking for tokens until a rule matching all the internally stored tokens is found. If no rule is found then the parser will raise an exception. This means the document was not valid and contained syntax errors.

## Translation

> In many cases the parse tree is not the final product. Parsing is often used in translation: transforming the input document to another format. An example is compilation. The compiler that compiles source code into machine code first parses it into a parse tree and then translates the tree into a machine code document.

- [Compilation Flow](https://web.dev/static/articles/howbrowserswork/image/compilation-flow-57cfc3aa68a53_856.png)

## Parsing example

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

## Let's analyze the input `2 + 3 - 1`.

> 1. `The first substring that matches a rule is 2: according to rule #5 it is a term.`

> 2. `The second match is 2 + 3: this matches the third rule: a term followed by an operation followed by another term.`

> 3. `The next match will only be hit at the end of the input. 2 + 3 - 1 is an expression because we already know that 2 + 3 is a term, so we have a term followed by an operation followed by another term. 2 + + will not match any rule and therefore is an invalid input.`

## Formal definitions for vocabulary and syntax

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

## Types of parsers

> There are two types of parsers: top down parsers and bottom up parsers. An intuitive explanation is that top down parsers examine the high level structure of the syntax and try to find a rule match. Bottom up parsers start with the input and gradually transform it into the syntax rules, starting from the low level rules until high level rules are met.

> The top down parser will start from the higher level rule: it will identify 2 + 3 as an expression. It will then identify 2 + 3 - 1 as an expression (the process of identifying the expression evolves, matching the other rules, but the start point is the highest level rule).

> The bottom up parser will scan the input until a rule is matched. It will then replace the matching input with the rule. This will go on until the end of the input. The partly matched expression is placed on the parser's stack.

| Stack   | Input |
| -------- | ------- |
|    |   2 + 3 - 1  |
|  term  |   + 3 - 1  |
|  term operation  |  3 - 1   |
|  expression  |   - 1  |
|  expression operation  |   	1  |
|  expression  |  -   |

This type of bottom up parser is called a shift-reduce parser, because the input is shifted to the right (imagine a pointer pointing first at the input start and moving to the right) and is gradually reduced to syntax rules.

---

## Generating parsers automatically

> There are tools that can generate a parser. You feed them the grammar of your language - its vocabulary and syntax rules - and they generate a working parser. Creating a parser requires a deep understanding of parsing and it's not easy to create an optimized parser by hand, so parser generators can be very useful.

> WebKit uses two well known parser generators: Flex for creating a lexer and Bison for creating a parser (you might run into them with the names Lex and Yacc). Flex input is a file containing regular expression definitions of the tokens. Bison's input is the language syntax rules in BNF format.

## HTML Parser

> The job of the HTML parser is to parse the HTML markup into a parse tree.

### The HTML grammar definition

> The vocabulary and syntax of HTML are defined in specifications created by the W3C organization.

### Not a context free grammar

> As we have seen in the parsing introduction, grammar syntax can be defined formally using formats like BNF. 

> Unfortunately all the conventional parser topics do not apply to HTML (I didn't bring them up just for fun - they will be used in parsing CSS and JavaScript). HTML cannot easily be defined by a context free grammar that parsers need.

> There is a formal format for defining HTML - DTD (Document Type Definition) - but it is not a context free grammar.

> This appears strange at first sight; HTML is rather close to XML. There are lots of available XML parsers. There is an XML variation of HTML - XHTML - so what's the big difference?

> The difference is that the HTML approach is more "forgiving": it lets you omit certain tags (which are then added implicitly), or sometimes omit start or end tags, and so on. On the whole it's a "soft" syntax, as opposed to XML's stiff and demanding syntax.

> This seemingly small detail makes a world of a difference. On one hand this is the main reason why HTML is so popular: it forgives your mistakes and makes life easy for the web author. On the other hand, it makes it difficult to write a formal grammar. So to summarize, HTML cannot be parsed easily by conventional parsers, since its grammar is not context free. HTML cannot be parsed by XML parsers.

### HTML DTD

> HTML definition is in a DTD format. This format is used to define languages of the SGML family. The format contains definitions for all allowed elements, their attributes and hierarchy. As we saw earlier, the HTML DTD doesn't form a context free grammar.

> There are a few variations of the DTD. The strict mode conforms solely to the specifications but other modes contain support for markup used by browsers in the past. The purpose is backwards compatibility with older content. The current strict DTD is here: www.w3.org/TR/html4/strict.dtd

### DOM

> The output tree (the "parse tree") is a tree of DOM element and attribute nodes. DOM is short for Document Object Model. It is the object presentation of the HTML document and the interface of HTML elements to the outside world like JavaScript.

The root of the tree is the "Document" object.

The DOM has an almost one-to-one relation to the markup. For example:
```
<html>
  <body>
    <p>
      Hello World
    </p>
    <div> <img src="example.png"/></div>
  </body>
</html>
```
This markup would be translated to the following DOM tree:

[DOM Tree](https://web.dev/static/articles/howbrowserswork/image/dom-tree-the-example-mar-70be67fe14c9a_720.png)

> Like HTML, DOM is specified by the W3C organization. See www.w3.org/DOM/DOMTR. It is a generic specification for manipulating documents. A specific module describes HTML specific elements. The HTML definitions can be found here: www.w3.org/TR/2003/REC-DOM-Level-2-HTML-20030109/idl-definitions.html.

> When I say the tree contains DOM nodes, I mean the tree is constructed of elements that implement one of the DOM interfaces. Browsers use concrete implementations that have other attributes used by the browser internally.

### The Parsing Algorithm

> As we saw in the previous sections, HTML cannot be parsed using the regular top down or bottom up parsers.

The reasons are:

1. The forgiving nature of the language.

2. The fact that browsers have traditional error tolerance to support well known cases of invalid HTML.

3. The parsing process is reentrant. For other languages, the source doesn't change during parsing, but in HTML, dynamic code (such as script elements containing document.write() calls) can add extra tokens, so the parsing process actually modifies the input

Unable to use the regular parsing techniques, browsers create custom parsers for parsing HTML.

> The parsing algorithm is described in detail by the HTML5 specification. 

> he algorithm consists of two stages: tokenization and tree construction.

> - Tokenization is the lexical analysis, parsing the input into tokens. Among HTML tokens are start tags, end tags, attribute names and attribute values.

> The tokenizer recognizes the token, gives it to the tree constructor, and consumes the next character for recognizing the next token, and so on until the end of the input.

[HTML Parsing Flow](https://web.dev/static/articles/howbrowserswork/image/html-parsing-flow-taken-6118c51b92b56_720.png)

## The Tokenization Algorithm

> The algorithm's output is an HTML token. The algorithm is expressed as a state machine. Each state consumes one or more characters of the input stream and updates the next state according to those characters. The decision is influenced by the current tokenization state and by the tree construction state. This means the same consumed character will yield different results for the correct next state, depending on the current state. The algorithm is too complex to describe fully, so let's see a simple example that will help us understand the principle.

Basic example - tokenizing the following HTML:
```
<html>
  <body>
    Hello world
  </body>
</html>
```

> 1. The initial state is the "`Data state`". 

> 2. When the `<` character is encountered, the state is changed to "`Tag open state`". 

> 3. Consuming an `a-z` character causes creation of a "Start tag token", the state is changed to "`Tag name state`". 

> 4. We stay in this state until the `>` character is consumed. 

> 5. Each character is appended to the new token name. 

> 6. In our case the created token is an `html` token.

> 7. When the `>` tag is reached, the current token is emitted and the state changes back to the "`Data state`". 

> 8. The `<body>` tag will be treated by the same steps. 

> 9. So far the `html` and body tags were emitted. 

> 10. We are now back at the "`Data state`". 

> 11. Consuming the `H` character of `Hello world` will cause creation and emitting of a character token, this goes on until the `<` of `</body>` is reached. 

> 12. We will emit a character token for each character of `Hello world`.

> 13. We are now back at the "`Tag open state`". 

> 14. Consuming the next input `/` will cause creation of an `end tag token` and a move to the "`Tag name state`". 

> 15. Again we stay in this state until we reach `>`.

> 16. Then the new tag token will be emitted and we go back to the "`Data state`". 

> 17. The `</html>` input will be treated like the previous case.

[Tokenizing](https://web.dev/static/articles/howbrowserswork/image/tokenizing-example-input-9d0cc36689681_720.png)

## Tree construction algorithm

> When the parser is created the Document object is created. During the tree construction stage the DOM tree with the Document in its root will be modified and elements will be added to it. Each node emitted by the tokenizer will be processed by the tree constructor. For each token the specification defines which DOM element is relevant to it and will be created for this token. The element is added to the DOM tree, and also the stack of open elements. This stack is used to correct nesting mismatches and unclosed tags. The algorithm is also described as a state machine. The states are called "insertion modes".

Let's see the tree construction process for the example input:
```
<html>
  <body>
    Hello world
  </body>
</html>
```



















