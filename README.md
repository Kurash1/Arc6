# Arc6

**Arc6** is a scripting language designed to simplify and enhance the process of modding Paradox Interactive games, particularly *Europa Universalis IV* (EU4). The language provides robust compile-time operations that address the limitations of runtime modding in these games, making it easier to develop and maintain complex mods.

Arc6 is not intended to be used as a standalone language but as a foundational tool for building frameworks tailored to specific games. For instance, **Valley** is an Arc6 framework currently in development that targets EU4 modding.

## Features

- **Support for Paradox Syntax**  
  Arc6 is designed to easily generate the syntax and file structures used by Paradox games.

- **Compile-Time Operations**  
  Powerful compile-time features enable you to automate and simplify modding tasks that are difficult or impossible at runtime.

- **Framework-Friendly**  
  Arc6 is minimalistic by design, providing the core features needed to build more specialized frameworks for different games.

- **Extensible**  
  While Arc6 is bare-bones, it’s built to be extended, allowing the creation of comprehensive tools for specific modding needs.

## Getting Started

### Prerequisites

- **A Game**  
  Arc6 is built with modding Paradox games in mind, but it can be used for other games as well.

- **A Text Editor or IDE**  
  You'll need a code editor to write Arc6 scripts.

### Installation

1. **Build or download the Arc6 compiler:**
   - Detailed build instructions can be found in the [Build Guide](./docs/Build_Guide.md).
   - Alternatively, download a pre-built version from the [releases page](link-to-releases).

2. **Create an `Arc.Defines` file**  
   Instructions can be found in the [Defines Guide](./docs/Defines_Guide.md).

3. **Compile your Arc6 project** by running the following command:

   `arc6 ./arc.defines --format`
 
   This command will define, run, compile, and transpile all files as specified in `arc.defines`.
    
   And there you go! You have an Arc6 project set up. Every project needs a separate installation of the compiler to ensure that all developers always compile the same result.

## Documentation

- [**Language Specification**](./docs/Language_Specification.md): Comprehensive guide to Arc6 syntax and semantics.
- [**Compile-Time Operations**](./docs/Compile_Time_Operations.md): Details on the powerful compile-time features unique to Arc6.
- [**Paradox Game Integration**](./docs/Paradox_Game_Integration.md): Instructions for using Arc6 with various Paradox games.
- [**Framework Development**](./docs/Framework_Development.md): How to create frameworks like Valley using Arc6.

## Contributing

Contributions to Arc6 are welcome! Please read our [Contributing Guide](./CONTRIBUTING.md) to get started.

## License

Arc6 is licensed under the MIT License. See the [LICENSE](./LICENSE) file for more information.
