# Rook

Rook is a custom trader mod for SPT.

This repository contains the source code for Rook, including separate projects for the supported SPT versions.

## Current Release

**Rook 1.0.0 — Initial Release**

This is the initial public release of Rook. Future versions may expand the trader with additional content, balancing, quests, and other improvements.

## Supported SPT Versions

- SPT 4.1.6
- SPT 4.0.13

Each supported version has its own source project:

- `SPT-4.1.6`
- `SPT-4.0.13`

## Installation

Use the release archive that matches your installed SPT version.

### SPT 4.1.6

Extract the archive into your main SPT installation folder.

Rook will be installed to:

`SPT_Runtime/user/mods/YDLonewolf-Rook`

### SPT 4.0.13

Extract the archive into your main SPT installation folder.

Rook will be installed to:

`SPT/user/mods/YDLonewolf-Rook`

Do not mix builds intended for different SPT versions.

## Building from Source

Open the project for the SPT version you want to build and compile it using the `Release` configuration.

The projects automatically create version-specific release archives.

### Framework Targets

- SPT 4.1.6: `.NET 10`
- SPT 4.0.13: `.NET 9`

## Repository Structure

```text
YDLonewolf-Rook/
├── SPT-4.0.13/
├── SPT-4.1.6/
├── LICENSE
└── README.md