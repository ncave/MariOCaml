F# [Fable](hhttp://fable.io/blog/Introducing-1-0-beta.html) port of [MariOCaml](https://mahsu.github.io/mariocaml/) from OCAML [BuckleScript](https://github.com/bloomberg/bucklescript)
=============

Fable and Bucklescript are similar projects which both use OCAML (F# is based on OCAML) to compile to JavaScript.
I ported the OCAML version to F# to compare the two approaches in terms of code readability, tooling and generated code.

[MariOCaml](https://mahsu.github.io/mariocaml/)  is a port of Mahsu's work to the excellent [BuckleScript](https://github.com/bloomberg/bucklescript) compiler, for the whole
game it generates only *7K* byte gzipped JS and takes 0.57s to build (including the start up time of npm).

MariOCaml is an HTML 5 canvas web-browser implementation of a well known platformer written exclusively in OCaml.

![Gameplay preview](https://github.com/mahsu/MariOCaml/raw/master/screenshots/preview.gif)

[Try MariOCaml build with Bucklescript](http://zhanghongbo.me/MariOCaml/)

# F# Fable 1.x Build & Rollup 

Windows, Max, Linux - requires [.net Core](https://www.microsoft.com/net/download/core)

```
dotnet restore
npm install
dotnet fable npm-run rollup
```

## OCAML/Bucklescript Size info

```
   7k 04-28 14:27 mario.clsoure.simple.js.gz # minify, zipped production build
20.3k 04-28 14:27 mario.clsoure.simple.js # minify, non zipped
  15k 04-28 14:27 mario.rollup.js.gz #  zipped
 104k 04-28 14:27 mario.rollup.js # non minify, non zipped WITH COMMENTS
```

The production build is 7K byte (gzip)
3. Open `index.html` to run!

## Fable F#
  83k mario.rollup.js # non minify, non zipped WITHOUT COMMENTS

## Comparison between OCAML and F#
  
At first glance Fable beats Bucklescript on JS code size, but OCAML leaves comments in the rollup.
Bucklescript generated JS can be compressed better by [Google Closure Compiler](https://developers.google.com/closure/compiler/)

- F# syntax is more lightweight but mostly compatible (see diff on porting commit in GIT)
- F# tooling is much better thanks to Ionide with live type inference
- Fable Javascript syntax looks more natural to me and offers auto-complete / type safety
- OCAML compiler is much faster (Fable has many passes: F# -> .net AST -> Fable -> Babel AST -> Babel -> JS)
- Bucklescript JS code seems slightly more optimized when using OCAML language features

## Key Features
* 2D Mario platformer that emulates the platformer mechanics of Super Mario Bros.
* Web-based playable implementation with graphics (Ocaml transpiled to javascript).
* Procedural level generator that randomly generates levels.

## Description

MariOcaml is an OCaml implementation of Super Mario Bros. The game includes several basic enemies, blocks, and items, with particle support. The underlying system follows a director model, with the director maintaining state based on game objects and tiles, including Mario, items, and obstacles. The implementation of enemies and items is designed to be easily extensible. Furthermore, MariOcaml supports a game-over and game-win states, as well as score and coin counts, emulating several of the core mechanics of Mario.

The design follows a clean, modular, and extensible system to ensure that more features can easily be added. Levels are procedurally generated (pseudo-randomly), algorithmically creating an environment of textures and objects that are interactable. The procedural generation generally generates a playable map, but due to the nature of random generation, maps may not be the most aesthetically appealing. Additionally, the game is interactive and graphical using js\_of\_ocaml, which enables cross-compiliation of Ocaml to javascript, allowing MariOcaml to be run in any modern web browser.

The underlying procedural generation utilizes a grid system to generate objects, taking account parameters such as proximity and location. During game-play, the director maintains the game state, including the location and status of both items, enemies, and the character.

## Modules
* **Director** - The heart of the game, executes the main game loop and performs updates on the map, canvas, and objects. Also executes the side effectual collision detection.
* **Viewport** - Represents a slice of the game map which is currently in view and rendered on the canvas.
* **Procedural Generator** - Generates the game level in a game map to be played.
* **Actors** - Represents the characters, items, and obstacles in the Mario game world.
* **Sprite** - The visual representation of an object to be drawn on the canvas. Contains the ability to create sprites from a template configuration based on the type of actor.
* **Object** - The abstract representation of a specific actor on the game map. Contains the ability to create objects from a template configuration based on the type of actor.
* **Particle** - Represents a non-collidable visually oriented object on the map. This includes destruction and creation effects.
* **Draw** - Contains methods which update the canvas.



## Contributing
Pull requests fixing bugs, adding functionality, or improving organization are welcome!

## Authors
MariOCaml was originally conceived for Cornell University's Fall 2015 CS3110 final project.
* Matthew Hsu ([@mahsu](https://github.com/mahsu))
* Ashley Xue ([@ashleyxue529](https://github.com/ashleyxue529))
* Liam Bui ([@LiamBui](https://github.com/liambui))



