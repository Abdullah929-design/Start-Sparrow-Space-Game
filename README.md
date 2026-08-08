# Start Sparrow — Space Game

A small, fast-paced top-down space shooter built in Unity. Pilot the Sparrow through enemy waves, dodge obstacles, collect power-ups, and survive as long as you can.

![Engine](https://img.shields.io/badge/engine-Unity%202020.3%2B-black?logo=unity)
![Platform](https://img.shields.io/badge/platform-PC%20%7C%20Mobile-blue)
![License](https://img.shields.io/badge/license-MIT-green)

## Table of Contents
- [Demo](#demo)
- [Features](#features)
- [Controls](#controls)
- [Installation / Run](#installation--run)
- [Build](#build)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Demo

[![Watch the Demo](https://img.shields.io/badge/▶-Watch%20Gameplay%20Demo-1f6feb?style=for-the-badge)](https://res.cloudinary.com/dv7fu8gwf/video/upload/v1786215738/My_project_1_-_Level2_-_Windows_Mac_Linux_-_Unity_2022.3.62f3__DX11__2026-08-08_23-58-29_z0oehz.mp4)

*Click the button above to watch the full gameplay demo.*

> GitHub strips raw `<video>` tags from rendered READMEs, so a native inline player isn't possible on github.com. The badge above works immediately with no extra files needed. For a richer preview:
> - **Best result:** add a short looping GIF at `docs/demo.gif` and swap the badge line for `![Demo](docs/demo.gif)` — GIFs autoplay directly in the README with no click needed.
> - **True inline playback:** drag-and-drop the mp4 into a GitHub issue/PR comment box on github.com — GitHub will host it and give you a `user-images.githubusercontent.com` URL that *does* play inline in rendered markdown. Swap that URL in here once you have it.

## Features
- Player movement and shooting
- Multiple enemy types and wave spawning
- Power-ups (health, shields, weapon upgrades)
- Score tracking and high-score saving (PlayerPrefs)
- Simple UI: health, score, wave counter
- Mobile and PC input support

## Controls
| Action | PC | Mobile/Gamepad |
|---|---|---|
| Move | WASD / Arrow keys | Left joystick |
| Fire | Left mouse button | Gamepad trigger |
| Special | Space | Gamepad button |
| Pause | Esc | Start |

## Installation / Run
1. Install Unity (recommended: 2020.3 LTS or newer) and required platform modules.
2. Clone the repository:
```bash
   git clone https://github.com/Abdullah929-design/Start-Sparrow-Space-Game.git
   cd Start-Sparrow-Space-Game
```
3. Open the project in Unity Hub and let it import assets.
4. Open the main scene (check `Assets/Scenes/` for the correct scene file) and press Play.

## Build
- **PC:** File > Build Settings > select platform > Build
- **Mobile:** add Android/iOS modules in Unity, configure Player Settings, then build

## Project Structure
## Project Structure

Assets/
├── Scenes/
├── Scripts/ (Player, Enemy, Spawner, UI)
├── Prefabs/
├── Art/
├── Audio/
└── UI/


## Contributing
1. Fork the repo
2. Create a branch: `git checkout -b feat/my-feature`
3. Commit and push your changes
4. Open a pull request describing what you changed and why

Please avoid committing large binaries directly — use GitHub Releases or Git LFS for large assets.

## License
MIT — add a `LICENSE` file to the repo root, or replace this section with your chosen license.

## Contact
Maintainer: **Abdullah Aqeel** — [@Abdullah929-design](https://github.com/Abdullah929-design)
