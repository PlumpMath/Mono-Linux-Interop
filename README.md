# Mono-Linux-Interop
Mono Interop Sample on Linux

## Setup

* Instruct Linux to search for our shared library ``` libfact.so ```

Add following to ``` ~/.bashrc ``` file and issue ``` source ~/.bashrc ``` command for changes to take effect immediately. This change is needed to instruct Linux runtime that it should search for the shared libraries in the specified path too.

``` export LD_LIBRARY_PATH=/usr/local/lib:$LD_LIBRARY_PATH ```

* Grant access to copy the shared library produced by the makefile ``` libfact.so ``` under ``` /usr/local/lib ```

User running makefile should have write access to the folder ``` /usr/local/lib ```. If the box you are testing is a test box, just issue ``` # sudo chmod 777 /usr/local/lib ``` to grant full access.
