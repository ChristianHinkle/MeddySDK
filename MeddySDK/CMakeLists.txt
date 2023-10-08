
cmake_minimum_required(VERSION 3.8)

project(MeddySDK LANGUAGES CXX)

# We want to be build interface users of our subprojects instead of install
# interface users, i.e., we want to build with our subprojects instead of building off
# of pre-built binaries of them. This is how the development environment should be. We
# want to build and develop all of these subprojects together.

include(FetchContent)

# Declare subprojects.
#
# We use `FetchContent_Declare()` to allow us to build with our subprojects instead
# of building off of intalled packages of them.
#
# The `find_package()` command is what our projects use to retrieve external dependencies
# and its default behavior looks through installed files to get them. So we use `OVERRIDE_FIND_PACKAGE`
# to have it look to FetchContent declarations instead.
#
# Our subprojects exist as subdirectories so we just have their FetchContent
# declarations refer to them by directory path.

FetchContent_Declare(MeddySDK_Meddyproject
  SOURCE_DIR "${MeddySDK_SOURCE_DIR}/MeddySDK.Meddyproject"
  SOURCE_SUBDIR "MeddySDK.Meddyproject"
  OVERRIDE_FIND_PACKAGE
  )

FetchContent_Declare(MeddySDKCLI
  SOURCE_DIR "${MeddySDK_SOURCE_DIR}/MeddySDKCLI"
  SOURCE_SUBDIR "MeddySDKCLI"
  OVERRIDE_FIND_PACKAGE
  )

# Add subprojects.
#
# We use `FetchContent_MakeAvailable()` because it avoids project duplication for
# us. If we were to use `add_subdirectory()` ourselves directly, we would have to set up
# guards against adding subdirectories multiple times. That's prone to happening
# when a project is needed as a dependency several times.

FetchContent_MakeAvailable(MeddySDK_Meddyproject)

FetchContent_MakeAvailable(MeddySDKCLI)
