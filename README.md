# Start Sparrow — Space Game

A small, fast-paced top-down space shooter built in Unity. Pilot the Sparrow through enemy waves, dodge obstacles, collect power-ups, and survive as long as you can. This README includes a playable demo link and guidance for running and contributing to the project.

---

## Demo

**Demo video (direct link):** https://res.cloudinary.com/dv7fu8gwf/video/upload/v1786215738/My_project_1_-_Level2_-_Windows_Mac_Linux_-_Unity_2022.3.62f3__DX11__2026-08-08_23-58-29_z0oehz.mp4

You can also embed a playable video tag in HTML — GitHub sometimes doesn't render embedded videos in README files, so I included the direct link above as a reliable fallback. If you'd like an inline preview on GitHub, add a short GIF at `docs/demo.gif` and replace the direct link with `![Demo](docs/demo.gif)`.

<!-- Optional: HTML5 video (may not render on GitHub) -->
<video controls width="640">
  <source src="https://res.cloudinary.com/dv7fu8gwf/video/upload/v1786215738/My_project_1_-_Level2_-_Windows_Mac_Linux_-_Unity_2022.3.62f3__DX11__2026-08-08_23-58-29_z0oehz.mp4" type="video/mp4">
  Your browser does not support the video tag. You can view the demo here: [Demo video](https://res.cloudinary.com/dv7fu8gwf/video/upload/v1786215738/My_project_1_-_Level2_-_Windows_Mac_Linux_-_Unity_2022.3.62f3__DX11__2026-08-08_23-58-29_z0oehz.mp4)
</video>

> Note: If the embedded video doesn't show on GitHub, use the direct link above or add a short demo GIF (e.g., `docs/demo.gif`) or upload the video to YouTube/itch.io and link to it.

---

## Features

- Player movement and shooting
- Multiple enemy types and wave spawning
- Power-ups (health, shields, weapon upgrades)
- Score tracking and high-score saving (PlayerPrefs)
- Simple UI: health, score, wave counter
- Mobile and PC input support

---

## Controls

- Move: WASD or arrow keys / left joystick
- Fire: Left mouse button / gamepad trigger
- Special: Space / gamepad button
- Pause: Esc / Start

---

## Installation / Run

1. Install Unity (recommended: 2020.3 LTS or newer) and required platform modules.
2. Clone the repository:

```bash
git clone https://github.com/Abdullah929-design/Start-Sparrow-Space-Game.git
cd Start-Sparrow-Space-Game
```

3. Open the project in Unity Hub and let it import assets.
4. Open the main scene (check `Assets/Scenes/` for the correct scene file) and press Play.

---

## Build

- For PC: File > Build Settings > select platform > Build
- For Mobile: add Android/iOS modules in Unity, set Player Settings, and build

---

## Project structure (example)

- Assets/
  - Scenes/
  - Scripts/ (Player, Enemy, Spawner, UI)
  - Prefabs/
  - Art/
  - Audio/
  - UI/

---

## Contributing

1. Fork the repo
2. Create a branch: `git checkout -b feat/my-feature`
3. Commit and push
4. Open a pull request describing your changes

Please avoid committing large binaries; use releases or LFS if needed.

---

## License

Add a LICENSE file (MIT recommended) or replace this section with your chosen license.

---

## Contact

Maintainer: Abdullah Aqeel — https://github.com/Abdullah929-design

If you'd like changes (different layout, screenshots, GIF preview, or hosting the video on YouTube), tell me and I can update the README and/or add the demo GIF to the repo.
