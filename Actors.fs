module Actors

type dir_1d = | Left | Right
type dir_2d = | North | South | East | West

let eq_dir_1d x  y =
  match x with
  | Left -> y = Left
  | Right -> y = Right
             
type xy = {
  mutable x: float;
  mutable y: float;
}

type controls =
  | CLeft
  | CRight
  | CUp
  | CDown

type pl_typ =
  | BigM
  | SmallM

type item_typ =
  | Mushroom
  | FireFlower
  | Star
  | Coin

type enemy_typ =
  | Goomba
  | GKoopa
  | RKoopa
  | GKoopaShell
  | RKoopaShell

type block_typ =
  | QBlock of item_typ
  | QBlockUsed
  | Brick
  | UnBBlock
  | Cloud
  | Panel
  | Ground

type player_typ =
  | Standing
  | Jumping
  | Running
  | Crouching

type part_typ =
  | GoombaSquish
  | BrickChunkL
  | BrickChunkR
  | Score100
  | Score200
  | Score400
  | Score800
  | Score1000
  | Score2000
  | Score4000
  | Score8000

type spawn_typ =
  | SPlayer of pl_typ * player_typ
  | SEnemy of enemy_typ
  | SItem of item_typ
  | SBlock of block_typ
