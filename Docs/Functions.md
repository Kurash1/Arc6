In Arc6, functions are a key feature that allows you to define reusable blocks of code with parameters. This enables modular and maintainable code, as well as the ability to perform specific operations based on input arguments.

# Defining a Function

To define a function in Arc6, you use the new function syntax. Here's the general structure:
```
new function <function_name> = {
  args = <argument_types>
  <function_body>
}
```

`<function_name>`: The name of the function.

`<argument_types>`: The types of arguments the function accepts, specified as a list of types.

`<function_body>`: The code to be executed when the function is called, using the provided arguments.

Example:
```
new function add_treasury = {
  args = int
  add_treasury = args
}
```
This defines a function `add_treasury` that takes a single integer argument and transpiles into `add_treasury = x`

# Calling a Function

To call a function in Arc6, you simply use its name followed by parentheses containing the arguments. The arguments should match the types and order specified in the function definition.

```<function_name>(<arguments>)```

Example:

```
add_treasury(500)
```
which would transpile into
```
add_treasury = 500
```
