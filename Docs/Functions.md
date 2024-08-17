In Arc6, functions are a key feature that allows you to define reusable blocks of code with parameters. This enables modular and maintainable code, as well as the ability to perform specific operations based on input arguments.

# Defining a Function

To define a function in Arc6, you use the new function syntax. Here's the general structure:
```
new function <function_name> = {
	type = <function_type>
	args = <argument_type>
	<function_body>
}
```

`<function_name>`: The name of the function.

`<function_type>`: The type of function, this is defined by the `function_types` enum.

`<argument_types>`: The types of arguments the function accepts, specified as a list of types.

`<function_body>`: The code to be executed when the function is called, using the provided arguments.

Example:
```
new function add_treasury = {
	type = effect
	args = int
	add_treasury = args
}
```
This defines a function `add_treasury` that takes a single integer argument. If args is 500, then calling the function results in `add_treasury = 500`.

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

# Practical Example

Let’s put this into practice with a more detailed example.

Function Definition:
```
new function conditional_effect = {
	type = effect
	args = {
		tooltip = string
		trigger = trigger
		effect = effect
	}

	if [args:trigger] {
		new_custom_tooltip = "£yes£If {args:tooltip}"
		args:effect
	}
	else {
		new_custom_tooltip = "£no£If {args:tooltip}"
		tooltip = {
			args:effect
		}
	}
}
```

This function `conditional_effect` takes three arguments: a tooltip, a trigger, and an effect. In game it shows a tooltip that allows players to see what effect they would get if the fulfill the trigger, with a yes/no icon to show whether they fulfill it.
