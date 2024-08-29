In Arc6, functions are powerful compile-time constructs designed to automate and simplify the process of generating mod scripts for Paradox Interactive games. Unlike traditional programming languages where functions exist and operate at runtime, functions in Arc6 are purely compile-time operations. This means that they are used to manipulate data and generate output scripts before the game even loads the mod.

# Defining a Function

To define a function in Arc6, you use the func keyword followed by the function's intended output type, name, and any required arguments. Here's the general syntax:
```
func <return type> <function_name>(<arguments>) {
	<function_body>
}
```

`<return type>`: The type of output this function will generate.

`<function_name>`: The name of the function used to reference it within Arc6 scripts.

`<arguments>`: A list of parameters the function will accept to perform its operations.

`<function_body>`: The code executed at compile time to generate the desired output.

Example:
```
func effect add_treasury(money: int) {
	add_treasury = money
}
```
In this example:

`effect` is the output type.

`add_treasury` is the function name.

`money` is the argument, expected to be an integer.

When this function is called, it generates the code `add_treasury = <money>` directly in the final mod files.

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

Let's explore a more complex function that uses compile-time logic to generate conditional game effects.

Function Definition:

```
func effect conditional_effect(tooltip: string, trigger: trigger, effect: effect) {
	if [args:trigger] {
		new_custom_tooltip("£yes£If {tooltip}")
		effect
	}
	else {
		new_custom_tooltip("£no£If {tooltip}")
		tooltip -> {
			effect
		}
	}
}
```

This function `conditional_effect` takes three arguments: a tooltip, a trigger, and an effect. In game it shows a tooltip that allows players to see what effect they would get if the fulfill the trigger, with a yes/no icon to show whether they fulfill it.
