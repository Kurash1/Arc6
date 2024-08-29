Arc.defines is a special file that tells the Arc6 compiler how to handle your mod. It tells the compiler everything it needs to know about it.

Example:
```
load_order: {
	valley/*
	src/*
}
external_dlls: {}
target_directory: target
```
Components of `Arc.defines`:

`load_order`: this defines in what order should the compiler load your files

`external_dlls`: this defines whether the compiler should load any additional dlls

`target_directory`: this defines where the write_file and similar functions should write to
