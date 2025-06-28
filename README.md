# Dragon Battle Game 
_A turn-based elemental showdown!_

## Overview
Welcome to **Dragon Battle**, an intense two-player, turn-based combat game where legendary dragons clash in a test of strategy, strength, and survival. Choose your dragon, roll the dice for initiative, and unleash your fury in this action-packed battle inspired by games like Pokémon.

Created as part of the GADE5121 Portfolio of Evidence, this game demonstrates fundamental programming concepts including GUI design, decision structures, arrays, methods, and more.

## 🎮 How to Play

### 🧍‍♂️ Setup Phase
- **Two players** enter their names and choose one of four elemental dragons:
  - ❄️ **Ice Dragon** – Balanced stats and a solid defense.
  - 🔥 **Fire Dragon** – High attack, low HP.
  - 🌪️ **Wind Dragon** – High HP, low attack.
  - 🪨 **Earth Dragon** – Tank-like with the highest HP and block.

- Each dragon has unique stats:
  - **HP (Health Points)**
  - **Attack Damage**
  - **Special Attack Damage**
  - **Block Damage**

- Once both players are ready, hit "Start Game" to begin!

### Battle Phase
- At the start of each round, players roll a die to determine **initiative**.
- On your turn, choose one of the following actions:
  - **Attack** – Deal base damage to your opponent.
  - **Special Attack** – Deal massive damage, but you must rest on your next turn.
  - **Block** – Reduce incoming damage from the next attack.

> **Note**: Blocks do not stack, and special attacks leave the dragon vulnerable for one turn.

- Play continues until one dragon's HP drops to **zero** or below. The survivor is **crowned champion**!

## Game Logic

- Dragons are stored using arrays for names and stats.
- Player turns alternate automatically with visual updates on the Turn Player form.
- Special flags manage blocking and exhaustion states.
- Initiative is rerolled at the start of every round (two turns).
- A battle log keeps players updated with every move and effect.

## Features

- Interactive **Graphical User Interface** (GUI) with vibrant visuals.
- **Dynamic turn system** that adapts based on actions taken.
- **Battle log** for real-time updates.
- Sound effects, colourful themes, and animated transitions (customizable).

## Getting Started

1. Clone the repository from GitHub.
2. Open the project in Visual Studio.
3. Build and run the project.
4. Play locally with two players using the GUI.

## Tech Stack

- Language: **C#**
- Framework: **.NET Windows Forms**
- Tools: **Visual Studio 2022**, **GitHub**
