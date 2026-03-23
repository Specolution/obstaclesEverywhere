# Obstacles Everywhere

An Unreal Engine third-person platformer project featuring obstacle-based gameplay.

## Project Structure

- **Source/ObstacleEverywhere/** — C++ source code
  - `MovingPlatform` — Actor class for moving platform obstacles
  - `ObstacleEverywhereCharacter` — Player character
  - `ObstacleEverywhereGameMode` — Game mode
  - `ObstacleEverywherePlayerController` — Player controller
  - `MyActor` — Generic actor class

## Features

- Third-person character controller
- Moving platform obstacles with configurable speed (`memberFloat`)
- Test level for rapid iteration
- Game variants:
  - Combat
  - Platforming
  - Side-scrolling

## Getting Started

1. Open `ObstacleEverywhere.uproject` in Unreal Engine
2. Build the C++ solution via `ObstacleEverywhere.sln`
3. Open the test level and play
