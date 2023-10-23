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

> The input to the tree construction stage is a sequence of tokens from the tokenization stage. The first mode is the "`initial mode`". Receiving the "html" token will cause a move to the "`before html`" mode and a reprocessing of the token in that mode. This will cause creation of the HTMLHtmlElement element, which will be appended to the root Document object.

> The state will be changed to "`before head`". The "body" token is then received. An HTMLHeadElement will be created implicitly although we don't have a "head" token and it will be added to the tree.

> We now move to the "`in head`" mode and then to "`after head`". The body token is reprocessed, an HTMLBodyElement is created and inserted and the mode is transferred to "`in body`".

> The character tokens of the "Hello world" string are now received. The first one will cause creation and insertion of a "Text" node and the other characters will be appended to that node.

> The receiving of the body end token will cause a transfer to "`after body`" mode. We will now receive the html end tag which will move us to "`after after body`" mode. Receiving the end of file token will end the parsing.

[Tree Construction](https://web.dev/static/articles/howbrowserswork/image/tree-construction-exampl-4e9757a851f96.gif)

## Actions when the parsing is finished

> At this stage the browser will mark the document as interactive and start parsing scripts that are in "deferred" mode: those that should be executed after the document is parsed. The document state will be then set to "complete" and a "load" event will be fired.

> You can see the full algorithms for tokenization and tree construction in the HTML5 specification:

> - https://html.spec.whatwg.org/multipage/parsing.html#html-parser

---

## Browsers' error tolerance

> You never get an "Invalid Syntax" error on an HTML page. Browsers fix any invalid content and go on.

Take this HTML for example:
```
<html>
  <mytag>
  </mytag>
  <div>
  <p>
  </div>
    Really lousy HTML
  </p>
</html>
```

> I must have violated about a million rules ("mytag" is not a standard tag, wrong nesting of the "p" and "div" elements and more) but the browser still shows it correctly and doesn't complain. So a lot of the parser code is fixing the HTML author mistakes.

> Error handling is quite consistent in browsers, but amazingly enough it hasn't been part of HTML specifications. Like bookmarking and back/forward buttons it's just something that developed in browsers over the years. There are known invalid HTML constructs repeated on many sites, and the browsers try to fix them in a way conformant with other browsers.

> The HTML5 specification does define some of these requirements. (WebKit summarizes this nicely in the comment at the beginning of the HTML parser class.)

> The parser parses tokenized input into the document, building up the document tree. If the document is well-formed, parsing it is straightforward.

> Unfortunately, we have to handle many HTML documents that are not well-formed, so the parser has to be tolerant about errors.

We have to take care of at least the following error conditions:

> 1. The element being added is explicitly forbidden inside some outer tag. In this case we should close all tags up to the one which forbids the element, and add it afterwards.

> 2. We are not allowed to add the element directly. It could be that the person writing the document forgot some tag in between (or that the tag in between is optional). This could be the case with the following tags: HTML HEAD BODY TBODY TR TD LI (did I forget any?).

> 3. We want to add a block element inside an inline element. Close all inline elements up to the next higher block element.

> 4. If this doesn't help, close elements until we are allowed to add the element - or ignore the tag.

Let's see some WebKit error tolerance examples:

### `</br>` instead of `<br>`

> Some sites use `</br>` instead of `<br>`. In order to be compatible with IE and Firefox, WebKit treats this like `<br>`.

The code:
```
if (t->isCloseTag(brTag) && m_document->inCompatMode()) {
     reportError(MalformedBRError);
     t->beginTag = true;
}
```

Note that the error handling is internal: it won't be presented to the user.

### A stray table

> A stray table is a table inside another table, but not inside a table cell.

For example: 
```
<table>
  <table>
    <tr><td>inner table</td></tr>
  </table>
  <tr><td>outer table</td></tr>
</table>
```
WebKit will change the hierarchy to two sibling tables:
```
<table>
  <tr><td>outer table</td></tr>
</table>
<table>
  <tr><td>inner table</td></tr>
</table>
```
The code:
```
if (m_inStrayTableContent && localName == tableTag)
        popBlock(tableTag);
```
> WebKit uses a stack for the current element contents: it will pop the inner table out of the outer table stack. The tables will now be siblings.

### Nested form elements

> In case the user puts a form inside another form, the second form is ignored.

The code:
```
if (!m_currentFormElement) {
        m_currentFormElement = new HTMLFormElement(formTag,    m_document);
}
```

### A too deep tag hierarchy

The comment speaks for itself.
```
bool HTMLParser::allowNestedRedundantTag(const AtomicString& tagName)
{

unsigned i = 0;
for (HTMLStackElem* curr = m_blockStack;
         i < cMaxRedundantTagDepth && curr && curr->tagName == tagName;
     curr = curr->next, i++) { }
return i != cMaxRedundantTagDepth;
}
```
### Misplaced html or body end tags

Again - the comment speaks for itself.
```
if (t->tagName == htmlTag || t->tagName == bodyTag )
        return;
```
> So web authors beware - unless you want to appear as an example in a WebKit error tolerance code snippet - write well formed HTML.

## CSS parsing

> Remember the parsing concepts in the introduction? Well, unlike HTML, CSS is a context free grammar and can be parsed using the types of parsers described in the introduction. In fact the CSS specification defines CSS lexical and syntax grammar.

> - https://www.w3.org/TR/CSS2/grammar.html

Let's see some examples:

The lexical grammar (vocabulary) is defined by regular expressions for each token:
```
comment   \/\*[^*]*\*+([^/*][^*]*\*+)*\/
num       [0-9]+|[0-9]*"."[0-9]+
nonascii  [\200-\377]
nmstart   [_a-z]|{nonascii}|{escape}
nmchar    [_a-z0-9-]|{nonascii}|{escape}
name      {nmchar}+
ident     {nmstart}{nmchar}*
```
"ident" is short for identifier, like a class name. "name" is an element id (that is referred by "#" )

The syntax grammar is described in BNF.
```
ruleset
  : selector [ ',' S* selector ]*
    '{' S* declaration [ ';' S* declaration ]* '}' S*
  ;
selector
  : simple_selector [ combinator selector | S+ [ combinator? selector ]? ]?
  ;
simple_selector
  : element_name [ HASH | class | attrib | pseudo ]*
  | [ HASH | class | attrib | pseudo ]+
  ;
class
  : '.' IDENT
  ;
element_name
  : IDENT | '*'
  ;
attrib
  : '[' S* IDENT S* [ [ '=' | INCLUDES | DASHMATCH ] S*
    [ IDENT | STRING ] S* ] ']'
  ;
pseudo
  : ':' [ IDENT | FUNCTION S* [IDENT S*] ')' ]
  ;
```
Explanation:

A ruleset is this structure:
```
div.error, a.error {
  color:red;
  font-weight:bold;
}
```
> `div.error` and `a.error` are selectors. The part inside the curly braces contains the rules that are applied by this ruleset. This structure is defined formally in this definition:
```
ruleset
  : selector [ ',' S* selector ]*
    '{' S* declaration [ ';' S* declaration ]* '}' S*
  ;
```
> This means a ruleset is a selector or optionally a number of selectors separated by a comma and spaces (S stands for white space). A ruleset contains curly braces and inside them a declaration or optionally a number of declarations separated by a semicolon. "declaration" and "selector" will be defined in the following BNF definitions.

## WebKit CSS parser

> WebKit uses Flex and Bison parser generators to create parsers automatically from the CSS grammar files. As you recall from the parser introduction, Bison creates a bottom up shift-reduce parser. Firefox uses a top down parser written manually. In both cases each CSS file is parsed into a StyleSheet object. Each object contains CSS rules. The CSS rule objects contain selector and declaration objects and other objects corresponding to CSS grammar.

[Parsing CSS](https://web.dev/static/articles/howbrowserswork/image/parsing-css-4531ebee58764_856.png)

## The order of processing scripts and style sheets

#### *Scripts*

> The model of the web is synchronous. Authors expect scripts to be parsed and executed immediately when the parser reaches a `<script>` tag. he parsing of the document halts until the script has been executed. If the script is external then the resource must first be fetched from the network - this is also done synchronously, and parsing halts until the resource is fetched. This was the model for many years and is also specified in HTML4 and 5 specifications. Authors can add the "defer" attribute to a script, in which case it will not halt document parsing and will execute after the document is parsed. HTML5 adds an option to mark the script as asynchronous so it will be parsed and executed by a different thread. 

#### *Speculative parsing*

> Both WebKit and Firefox do this optimization. While executing scripts, another thread parses the rest of the document and finds out what other resources need to be loaded from the network and loads them. In this way, resources can be loaded on parallel connections and overall speed is improved. Note: the speculative parser only parses references to external resources like external scripts, style sheets and images: it doesn't modify the DOM tree - that is left to the main parser.

#### *Style sheets*

> Style sheets on the other hand have a different model. Conceptually it seems that since style sheets don't change the DOM tree, there is no reason to wait for them and stop the document parsing. There is an issue, though, of scripts asking for style information during the document parsing stage. If the style is not loaded and parsed yet, the script will get wrong answers and apparently this caused lots of problems. It seems to be an edge case but is quite common. Firefox blocks all scripts when there is a style sheet that is still being loaded and parsed. WebKit blocks scripts only when they try to access certain style properties that may be affected by unloaded style sheets.

#### *Render tree construction*

> While the DOM tree is being constructed, the browser constructs another tree, the render tree. This tree is of visual elements in the order in which they will be displayed. It is the visual representation of the document. The purpose of this tree is to enable painting the contents in their correct order.

> Firefox calls the elements in the render tree "frames". WebKit uses the term renderer or render object.

> A renderer knows how to lay out and paint itself and its children.

WebKit's RenderObject class, the base class of the renderers, has the following definition:
```
class RenderObject{
  virtual void layout();
  virtual void paint(PaintInfo);
  virtual void rect repaintRect();
  Node* node;  //the DOM node
  RenderStyle* style;  // the computed style
  RenderLayer* containgLayer; //the containing z-index layer
}
```
> Each renderer represents a rectangular area usually corresponding to a node's CSS box, as described by the CSS2 spec. It includes geometric information like width, height and position.

> The box type is affected by the "display" value of the style attribute that is relevant to the node (see the style computation section). Here is WebKit code for deciding what type of renderer should be created for a DOM node, according to the display attribute:
```
RenderObject* RenderObject::createObject(Node* node, RenderStyle* style)
{
    Document* doc = node->document();
    RenderArena* arena = doc->renderArena();
    ...
    RenderObject* o = 0;

    switch (style->display()) {
        case NONE:
            break;
        case INLINE:
            o = new (arena) RenderInline(node);
            break;
        case BLOCK:
            o = new (arena) RenderBlock(node);
            break;
        case INLINE_BLOCK:
            o = new (arena) RenderBlock(node);
            break;
        case LIST_ITEM:
            o = new (arena) RenderListItem(node);
            break;
       ...
    }

    return o;
}
```
The element type is also considered: for example, form controls and tables have special frames.

> In WebKit if an element wants to create a special renderer, it will override the `createRenderer()` method. The renderers point to style objects that contains non geometric information.

### The render tree relation to the DOM tree 

> The renderers correspond to DOM elements, but the relation is not one to one. Non-visual DOM elements will not be inserted in the render tree. An example is the "head" element. Also elements whose display value was assigned to "none" will not appear in the tree (whereas elements with "hidden" visibility will appear in the tree).

> There are DOM elements which correspond to several visual objects. These are usually elements with complex structure that cannot be described by a single rectangle. For example, the "select" element has three renderers: one for the display area, one for the drop down list box and one for the button. Also when text is broken into multiple lines because the width is not sufficient for one line, the new lines will be added as extra renderers.

> Another example of multiple renderers is broken HTML. According to the CSS spec an inline element must contain either only block elements or only inline elements. In the case of mixed content, anonymous block renderers will be created to wrap the inline elements.

> Some render objects correspond to a DOM node but not in the same place in the tree. Floats and absolutely positioned elements are out of flow, placed in a different part of the tree, and mapped to the real frame. A placeholder frame is where they should have been.

[The render tree and the corresponding DOM tree. The "Viewport" is the initial containing block. In WebKit it will be the "RenderView" object](https://web.dev/static/articles/howbrowserswork/image/the-render-tree-the-corr-f699894ef4c75_856.png)

### The flow of constructing the tree

> In Firefox, the presentation is registered as a listener for DOM updates. The presentation delegates frame creation to the `FrameConstructor` and the constructor resolves style and creates a frame.

> In WebKit the process of resolving the style and creating a renderer is called "attachment". Every DOM node has an "attach" method. Attachment is synchronous, node insertion to the DOM tree calls the new node "attach" method.

> Processing the html and body tags results in the construction of the render tree root. The root render object corresponds to what the CSS spec calls the containing block: the top most block that contains all other blocks. Its dimensions are the viewport: the browser window display area dimensions. Firefox calls it `ViewPortFrame` and WebKit calls it `RenderView`. This is the render object that the document points to. The rest of the tree is constructed as a DOM nodes insertion.

See: https://www.w3.org/TR/CSS21/intro.html#processing-model

### Style Computation

> Building the render tree requires calculating the visual properties of each render object. This is done by calculating the style properties of each element.

> The style includes style sheets of various origins, inline style elements and visual properties in the HTML (like the "bgcolor" property).The later is translated to matching CSS style properties.

> The origins of style sheets are the browser's default style sheets, the style sheets provided by the page author and user style sheets - these are style sheets provided by the browser user (browsers let you define your favorite styles. In Firefox, for instance, this is done by placing a style sheet in the "Firefox Profile" folder).

Style computation brings up a few difficulties:

1. Style data is a very large construct, holding the numerous style properties, this can cause memory problems.

2. Finding the matching rules for each element can cause performance issues if it's not optimized. Traversing the entire rule list for each element to find matches is a heavy task. Selectors can have complex structure that can cause the matching process to start on a seemingly promising path that is proven to be futile and another path has to be tried.

For example - this compound selector:
```
div div div div{
...
}
```

> Means the rules apply to a `<div>` who is the descendant of 3 divs. Suppose you want to check if the rule applies for a given `<div>` element. You choose a certain path up the tree for checking. You may need to traverse the node tree up just to find out there are only two divs and the rule does not apply. You then need to try other paths in the tree.

3. Applying the rules involves quite complex cascade rules that define the hierarchy of the rules.

Let's see how the browsers face these issues:

### Sharing style data

WebKit nodes references style objects (RenderStyle). These objects can be shared by nodes in some conditions. The nodes are siblings or cousins and:

1. The elements must be in the same mouse state (e.g., one can't be in :hover while the other isn't)

2. Neither element should have an id

3. The tag names should match

4. The class attributes should match

5. The set of mapped attributes must be identical

6. The link states must match

7. The focus states must match

8. Neither element should be affected by attribute selectors, where affected is defined as having any selector match that uses an attribute selector in any position within the selector at all

9. There must be no inline style attribute on the elements

10. There must be no sibling selectors in use at all. WebCore simply throws a global switch when any sibling selector is encountered and disables style sharing for the entire document when they are present. This includes the + selector and selectors like :first-child and :last-child.

### Firefox rule tree

> Firefox has two extra trees for easier style computation: the rule tree and style context tree. WebKit also has style objects but they are not stored in a tree like the style context tree, only the DOM node points to its relevant style.

[Firefox Style Context Tree](https://web.dev/static/articles/howbrowserswork/image/firefox-style-context-tre-f578b75b74df7_856.png)

> The style contexts contain end values. The values are computed by applying all the matching rules in the correct order and performing manipulations that transform them from logical to concrete values. For example, if the logical value is a percentage of the screen it will be calculated and transformed to absolute units. The rule tree idea is really clever. It enables sharing these values between nodes to avoid computing them again. This also saves space.

> All the matched rules are stored in a tree. The bottom nodes in a path have higher priority. The tree contains all the paths for rule matches that were found. Storing the rules is done lazily. The tree isn't calculated at the beginning for every node, but whenever a node style needs to be computed the computed paths are added to the tree.

The idea is to see the tree paths as words in a lexicon. Lets say we already computed this rule tree:

[Computed Rule Tree](https://web.dev/static/articles/howbrowserswork/image/computed-rule-tree-f874f412bbaf_856.png)

> Suppose we need to match rules for another element in the content tree, and find out the matched rules (in the correct order) are B-E-I. We already have this path in the tree because we already computed path A-B-E-I-L. We will now have less work to do.

Let's see how the tree saves us work.

### Division into structs

> The style contexts are divided into structs. Those structs contain style information for a certain category like border or color. All the properties in a struct are either inherited or non inherited. Inherited properties are properties that unless defined by the element, are inherited from its parent. Non inherited properties (called "reset" properties) use default values if not defined.

> The tree helps us by caching entire structs (containing the computed end values) in the tree. The idea is that if the bottom node didn't supply a definition for a struct, a cached struct in an upper node can be used.

### Computing the style contexts using the rule tree

> When computing the style context for a certain element, we first compute a path in the rule tree or use an existing one. We then begin to apply the rules in the path to fill the structs in our new style context. We start at the bottom node of the path - the one with the highest precedence (usually the most specific selector) and traverse the tree up until our struct is full. If there is no specification for the struct in that rule node, then we can greatly optimize - we go up the tree until we find a node that specifies it fully and simply point to it - that's the best optimization - the entire struct is shared. This saves computation of end values and memory.

If we find partial definitions we go up the tree until the struct is filled.

> If we didn't find any definitions for our struct then, in case the struct is an "inherited" type, we point to the struct of our parent in the `context tree`. In this case we also succeeded in sharing structs. If it's a reset struct then default values will be used.

> If the most specific node does add values then we need to do some extra calculations for transforming it to actual values. We then cache the result in the tree node so it can be used by children.

> In case an element has a sibling or a brother that points to the same tree node then the `entire style context` can be shared between them.

Lets see an example: Suppose we have this HTML
```
<html>
  <body>
    <div class="err" id="div1">
      <p>
        this is a <span class="big"> big error </span>
        this is also a
        <span class="big"> very  big  error</span> error
      </p>
    </div>
    <div class="err" id="div2">another error</div>
  </body>
</html>
```
And the following rules:
```
div {margin: 5px; color:black}
.err {color:red}
.big {margin-top:3px}
div span {margin-bottom:4px}
#div1 {color:blue}
#div2 {color:green}
```
> To simplify things let's say we need to fill out only two structs: the color struct and the margin struct. The color struct contains only one member: the color The margin struct contains the four sides.

The resulting rule tree will look like this (the nodes are marked with the node name: the number of the rule they point at):

[The Rule Tree](https://web.dev/static/articles/howbrowserswork/image/the-rule-tree-23f05b0dac33f_856.png)

The context tree will look like this (node name: rule node they point to):

[The Context Tree](https://web.dev/static/articles/howbrowserswork/image/the-context-tree-771124b7cb80d_856.png)

> Suppose we parse the HTML and get to the second `<div>` tag. We need to create a style context for this node and fill its style structs.

> We will match the rules and discover that the matching rules for the `<div>` are 1, 2 and 6. This means there is already an existing path in the tree that our element can use and we just need to add another node to it for rule 6 (node F in the rule tree).

> We will create a style context and put it in the context tree. The new style context will point to node F in the rule tree.

> We now need to fill the style structs. We will begin by filling out the margin struct. Since the last rule node (F) doesn't add to the margin struct, we can go up the tree until we find a cached struct computed in a previous node insertion and use it. We will find it on node B, which is the uppermost node that specified margin rules.

> We do have a definition for the color struct, so we can't use a cached struct. Since color has one attribute we don't need to go up the tree to fill other attributes. We will compute the end value (convert string to RGB etc) and cache the computed struct on this node.

> The work on the second `<span>` element is even easier. We will match the rules and come to the conclusion that it points to rule G, like the previous span. Since we have siblings that point to the same node, we can share the entire style context and just point to the context of the previous span.

> For structs that contain rules that are inherited from the parent, caching is done on the context tree (the color property is actually inherited, but Firefox treats it as reset and caches it on the rule tree).

For instance if we added rules for fonts in a paragraph:
```
p {font-family: Verdana; font size: 10px; font-weight: bold}
```
> Then the paragraph element, which is a child of the div in the context tree, could have shared the same font struct as his parent. This is if no font rules were specified for the paragraph.

> In WebKit, who does not have a rule tree, the matched declarations are traversed four times. First non-important high priority properties are applied (properties that should be applied first because others depend on them, such as display), then high priority important, then normal priority non-important, then normal priority important rules. This means that properties that appear multiple times will be resolved according to the correct cascade order. The last wins.

> So to summarize: sharing the style objects (entirely or some of the structs inside them) solves issues 1 and 3. The Firefox rule tree also helps in applying the properties in the correct order.

### Manipulating the rules for an easy match

There are several sources for style rules:

1. CSS rules, either in external style sheets or in style elements. `css p {color: blue}`

2. Inline style attributes like html `<p style="color: blue" />
`

3. HTML visual attributes (which are mapped to relevant style rules) `html <p bgcolor="blue" />` The last two are easily matched to the element since he owns the style attributes and HTML attributes can be mapped using the element as the key.

> As noted previously in issue #2, the CSS rule matching can be trickier. To solve the difficulty, the rules are manipulated for easier access.

> After parsing the style sheet, the rules are added to one of several hash maps, according to the selector. There are maps by id, by class name, by tag name and a general map for anything that doesn't fit into those categories. If the selector is an id, the rule will be added to the id map, if it's a class it will be added to the class map etc.

> This manipulation makes it much easier to match rules. There is no need to look in every declaration: we can extract the relevant rules for an element from the maps. This optimization eliminates 95+% of the rules, so that they need not even be considered during the matching process(4.1).

Let's see for example the following style rules:
```
p.error {color: red}
#messageDiv {height: 50px}
div {margin: 5px}
```
> The first rule will be inserted into the class map. The second into the id map and the third into the tag map.

For the following HTML fragment:
```
<p class="error">an error occurred</p>
<div id=" messageDiv">this is a message</div>
```

> We will first try to find rules for the p element. The class map will contain an "error" key under which the rule for "p.error" is found. The div element will have relevant rules in the id map (the key is the id) and the tag map. So the only work left is finding out which of the rules that were extracted by the keys really match.

For example if the rule for the div was
```
table div {margin: 5px}
```

it will still be extracted from the tag map, because the key is the rightmost selector, but it would not match our div element, who does not have a table ancestor.

> Both WebKit and Firefox do this manipulation.

### Applying the rules in the correct cascade order

> The style object has properties corresponding to every visual attribute (all CSS attributes but more generic). If the property is not defined by any of the matched rules, then some properties can be inherited by the parent element style object. Other properties have default values.

> The problem begins when there is more than one definition - here comes the cascade order to solve the issue.

### Style sheet cascade order

> A declaration for a style property can appear in several style sheets, and several times inside a style sheet. This means the order of applying the rules is very important. This is called the "cascade" order. According to CSS2 spec, the cascade order is (from low to high):

> 1. Browser declarations
> 2. User normal declarations
> 3. Author normal declarations
> 4. Author important declarations
> 5. User important declarations

> The browser declarations are least important and the user overrides the author only if the declaration was marked as important. Declarations with the same order will be sorted by specificity and then the order they are specified. The HTML visual attributes are translated to matching CSS declarations . They are treated as author rules with low priority.

### Specificity

> The selector specificity is defined by the CSS2 specification as follows:

https://www.w3.org/TR/CSS2/cascade.html#specificity

> 1. count 1 if the declaration it is from is a 'style' attribute rather than a rule with a selector, 0 otherwise (= a)

> 2. count the number of ID attributes in the selector (= b)

> 3. count the number of other attributes and pseudo-classes in the selector (= c)

> 4. count the number of element names and pseudo-elements in the selector (= d)

> Concatenating the four numbers a-b-c-d (in a number system with a large base) gives the specificity.

> The number base you need to use is defined by the highest count you have in one of the categories.

> For example, if a=14 you can use hexadecimal base. In the unlikely case where a=17 you will need a 17 digits number base. The later situation can happen with a selector like this: html body div div p… (17 tags in your selector… not very likely).

Some examples:
```
 *             {}  /* a=0 b=0 c=0 d=0 -> specificity = 0,0,0,0 */
 li            {}  /* a=0 b=0 c=0 d=1 -> specificity = 0,0,0,1 */
 li:first-line {}  /* a=0 b=0 c=0 d=2 -> specificity = 0,0,0,2 */
 ul li         {}  /* a=0 b=0 c=0 d=2 -> specificity = 0,0,0,2 */
 ul ol+li      {}  /* a=0 b=0 c=0 d=3 -> specificity = 0,0,0,3 */
 h1 + *[rel=up]{}  /* a=0 b=0 c=1 d=1 -> specificity = 0,0,1,1 */
 ul ol li.red  {}  /* a=0 b=0 c=1 d=3 -> specificity = 0,0,1,3 */
 li.red.level  {}  /* a=0 b=0 c=2 d=1 -> specificity = 0,0,2,1 */
 #x34y         {}  /* a=0 b=1 c=0 d=0 -> specificity = 0,1,0,0 */
 style=""          /* a=1 b=0 c=0 d=0 -> specificity = 1,0,0,0 */
```

### Sorting the rules

> After the rules are matched, they are sorted according to the cascade rules. WebKit uses bubble sort for small lists and merge sort for big ones. WebKit implements sorting by overriding the ">" operator for the rules:

```
static bool operator >(CSSRuleData& r1, CSSRuleData& r2)
{
    int spec1 = r1.selector()->specificity();
    int spec2 = r2.selector()->specificity();
    return (spec1 == spec2) : r1.position() > r2.position() : spec1 > spec2;
}
```

### Gradual process

> WebKit uses a flag that marks if all top level style sheets (including @imports) have been loaded. If the style is not fully loaded when attaching, place holders are used and it is marked in the document, and they will be recalculated once the style sheets were loaded.

## Layout
