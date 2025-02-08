# MeddySDK

The best practices of modern CMake consolidated into a collection of C++ projects.

CMake project structure:
- [MeddySDKCLI](https://github.com/ChristianHinko/MeddySDKCLI/blob/master/CMakeLists.txt)
    - Executable target.
    - Depends on [MeddySDK_Meddyproject](https://github.com/ChristianHinko/MeddySDK_Meddyproject/blob/master/CMakeLists.txt).
- [MeddySDK_Meddyproject](https://github.com/ChristianHinko/MeddySDK_Meddyproject/blob/master/CMakeLists.txt)
    - Library target.
    - ~~Depends on [BoostFilesystem](https://github.com/boostorg/filesystem/blob/develop/CMakeLists.txt).~~
        - This dependency has been eliminated. The project now uses `std::filesystem` as a replacement.

For a depenencies-included setup, see https://github.com/ChristianHinko/MeddySDKStandalone.
- This includes third-party libraries, such as the Boost C++ Libraries.

For the superbuild version of this project structure, see https://github.com/ChristianHinko/MeddySDKSuperbuild.
- The superbuild builds the projects together using ExternalProject instead of FetchContent.
