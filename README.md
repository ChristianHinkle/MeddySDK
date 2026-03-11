# MeddySDK

A superproject providing all the libraries MeddySDK has to offer. Each one is individually usable, although some may depend on others.

See [MeddySuperproject](https://github.com/ChristianHinkle/MeddySuperproject) for the rest of the Meddy repositories and further documentation.

Key benefits of this project structure I designed:
- Fulfills any CMake use case (namely, installation and local build use cases).
- Keeps dependencies isolated and accessible via `find_package` along with FetchContent or ExternalProject.
- Wrote automated tests with CTest, distributed products with CPack, and wrote reusable CMakePresets.

## Project Structure 📂

MeddySDK
- [MeddySDK_Meddyproject](https://github.com/ChristianHinkle/MeddySDK_Meddyproject) (library)
- [MeddySDK_Meddydata](https://github.com/ChristianHinkle/MeddySDK_Meddydata) (library)
- [MeddySDK_DAM](https://github.com/ChristianHinkle/MeddySDK_DAM) (library)

## Build System ⌨

Built with CMake - cross-platform, standardized, and IDE-friendly.

We provide CMake presets, which handle feeding arguments to CMake for you.

### IDE Support

Most IDEs provide built-in CMake integration.

#### VS Code

Has the "CMake Tools" and "C/C++" extensions, both developed by Microsoft.

#### Visual Studio

Has very nice integration, but they seem behind when it comes to supporting the latest CMake features. I've had experiences where I have to switch to VS Code because of this.

## Build Instructions 🔨

This project is fully isolated from its dependencies, and therefore must be tied together by a superproject. See [MeddySuperproject](https://github.com/ChristianHinkle/MeddySuperproject) for a complete build setup, as well as instructions for how to build, package, and test.
