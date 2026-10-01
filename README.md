# VR Assembly

VR Assembly is an interactive virtual reality assembly experience developed in Unity for Meta Quest. Players construct objects by grabbing physical pieces and placing them into their corresponding target locations while progressing through a guided sequence of assembly steps.

The project explores VR object manipulation, snapping, visual guidance, and step-based interaction design.

## Features

- VR object grabbing and manipulation
- Sequential assembly system
- Position- and rotation-based object snapping
- Visual highlighting of the current assembly piece
- Transparent goal objects for placement guidance
- Automatic locking of correctly placed pieces
- Step-by-step instructional UI
- Audio feedback for successful placement
- Assembly and disassembly support
- Multi-stage assembly progression

## Assembly System

The first activity guides the player through constructing a house from 15 individual pieces.

Each piece is associated with a target transform and a specific step in the assembly sequence. The currently required piece is visually highlighted to guide the player.

When the correct piece is moved sufficiently close to its target, the system automatically releases it from the player's grab interaction, aligns it with the target position and rotation, locks it in place, and advances to the next assembly step.

## Multi-Stage Progression

After completing the guided house assembly, a second construction set becomes available.

The second activity contains 18 pieces used to construct a pathway and environmental decorations, allowing the player to continue applying the VR assembly interactions introduced during the guided activity.

## Technologies

- Unity
- C#
- Meta Quest
- Meta/Oculus Interaction SDK
- Virtual Reality
- Rigidbody physics
- TextMesh Pro

## Interaction Design

Visual feedback helps communicate the current assembly objective:

- Transparent goal pieces indicate target locations.
- The active grabbable piece is highlighted to identify the next required component.
- Correctly positioned pieces automatically snap into place.
- On-screen instructions update as the player progresses through the assembly.

## Screenshots

### Goal Piece Guidance

<img width="1175" height="898" alt="Screenshot 2025-10-30 175242" src="https://github.com/user-attachments/assets/009f67eb-29e5-4b4c-8bde-b7b65f3124d4" />

### Grabbable Assembly Pieces

<img width="1176" height="896" alt="Screenshot 2025-10-30 175326" src="https://github.com/user-attachments/assets/3c1e7ce9-681a-474c-919d-adc6ffcb2e6e" />

## Project Background

VR Assembly was developed as a collaborative university virtual reality project focused on object manipulation and guided assembly interactions.

The project provided experience with Unity VR development, Meta Quest interactions, physics-based object manipulation, snapping systems, visual feedback, and sequential interaction design.

## Team

**Kian Miley**  
**John Blaufuss**
