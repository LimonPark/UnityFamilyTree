# 🧬 Unity Family Tree App

An interactive Unity application for visualizing and editing family relationships. Each node represents a person, and connections reflect parent-child and sibling relationships. Data is stored in JSON and rendered dynamically using modular architecture.

---

## 🚀 Features

- Visual nodes (`PersonNode`) with name, birth date, and gender-based color
- Dynamic creation, editing, and deletion of nodes
- Parent-child and sibling relationship rendering
- Persistent JSON-based data storage
- Unique time-stamped IDs for traceability

---

## 🧱 Architecture Overview

- `Person.cs` — Data model for individuals
- `FamilyTree.cs` — Container for all people and relationships
- `PersonNode.cs` — Visual representation of a person
- `FamilyTreeManager.cs` — Logic for loading, generating, and managing nodes
- `LineRenderer` — Visual connection between related nodes

---

## 🗂️ Project Structure

| Folder/File         | Purpose                                                                 |
|---------------------|-------------------------------------------------------------------------|
| `Assets/Scripts/`   | Contains all C# scripts: data models, logic controllers, visual nodes   |
| `Assets/Prefabs/`   | Stores reusable Unity prefabs like `PersonNode`                         |
| `Assets/Scenes/`    | Holds Unity scenes, including `Main.unity`                              |
| `StreamingAssets/`  | Stores external JSON files for persistent data                          |
| `ProjectSettings/`  | Unity project configuration (version, input, tags, etc.)                |
| `Packages/`         | Unity package dependencies and manifest                                 |

> This layout keeps your architecture modular and scalable — perfect for expanding into UI, media, or networked features later.

---

## 🧪 Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/LimonPark/UnityFamilyTree.git

1. Open the project in Unity (recommended: 2022.3+)
2. Launch the `Main.unity` scene
3. Nodes will be generated from `StreamingAssets/family.json`


---

## 📦 Roadmap

### 🎨 Visualization
- [ ] Auto-layout nodes by generation and relationships
- [ ] Render lines between parents, children, and siblings (`LineRenderer`)
- [ ] Support zooming and panning across the tree
- [ ] Rotate nodes toward the camera for better readability

### 🧠 Logic & Architecture
- [ ] Expand `Person` model (gender, photo, ID, relationships)
- [ ] Support unique time-stamped IDs for traceability
- [ ] Build tree from JSON with dynamic relationship mapping
- [ ] Add GEDCOM import/export support (future)

### 🖱️ UI & Interaction
- [ ] Clickable nodes with edit popup window
- [ ] Add/remove nodes via interface
- [ ] Validate input (e.g. unique IDs, required fields)
- [ ] Display media (photos, audio, video) on node click

### 💾 Data & Versioning
- [ ] Save changes to JSON in `StreamingAssets`
- [ ] Support multiple tree versions (e.g. by date or branch)
- [ ] Integrate Git for tracking tree history


---

## 🧠 Author

Developed by [Limon Park](https://github.com/LimonPark)  
Architectural mindset, modular logic, and scalable design principles.  
Focused on clarity, traceability, and deep understanding of data-driven systems.

---

## 📜 License

MIT — free to use and modify

---
