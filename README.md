# BasicFarm (Unity 2D Mobile Prototype) Unity version 6000.2.8f1

A lightweight **2D mobile-oriented prototype** focused on building **scalable gameplay systems**: quests, fruit collection, economy/shop, and a **responsive UI** (anchors, pivots, and proper scaling).

## Video Demo
- Demo video: (https://youtu.be/W39m_D-aBYk)

## Key Features
- **Scalable Quest System**
  - Simple quest progression structure designed to grow with more quests.
  - UI updates reflect quest state and rewards.

- **Scalable Fruit Collection**
  - Fruit counters and UI updated dynamically.
  - Designed so adding new fruits doesn’t require rewriting core logic.

- **Economy / Shop System**
  - Basic wallet + purchase flow (buying items/seeds).
  - Clear separation between UI display and gameplay logic.

- **Mobile-Friendly UI (Responsive)**
  - UI built with **anchors & pivots** in mind.
  - Consistent scaling across different resolutions/aspect ratios.

## Tech & Tools
- **Engine:** Unity *(add version here, e.g., 2022.3 LTS)*
- **Language:** C#
- **UI:** Unity UI + TextMeshPro
- **Target:** 2D / mobile-ready structure

## How to Run
1. Install Unity Hub
2. Open the project using the Unity version above
3. Open the main scene:
   - `Assets/Scenes/World.unity` *(change if different)*
4. Press **Play**

## Controls
- Tap/Click: Interact
- UI Buttons: Open inventory / quests / shop

## Project Structure (high level)
- `Assets/Scenes/` — main scene(s)
- `Assets/Scripts/` — gameplay logic (quests, fruit collection, wallet/shop, UI)
- `Assets/Art/` — sprites & UI visuals *(if you have it)*
- `ProjectSettings/` & `Packages/` — Unity configuration and dependencies

## What This Project Demonstrates
- Building **scalable systems** (quests + collectibles) with clean growth in mind
- Applying **mobile UI fundamentals**: anchors, pivots, and resolution scaling
- Practical Unity workflow: linking gameplay → UI updates cleanly

## Author
Juan José Rodríguez  
- GitHub: DevJrop  
- LinkedIn: *(paste link here)*  
- Email: *(paste email here)*
