The `new` keyword allows you to define global variables. Global variables are the most used variable type in arc as they are easily accessible to the framework developers when for example transpiling countries.

```
new <type> <id> <value>
```

This is the structure of the new keyword.

First you provide it a `type` which can be any of the primitive types or any predefined structs or classes.

The second argument `id` is the name of the variable with which you can access it in code. Generally global variables are created directly in the global scope however classes can define that their variables are instead created in a list named `x`, this means to access those variables you'd have to type x:`id` instead.

The third argument is the `value` of the variable.

```
new scaling_modifier custom_expenses {
	name: "Custom Expenses"
	type: province
	modifier: {
		local_state_maintenance_modifier: 0.001
	}
}
```

Here is an example of a `custom_expenses` variable of the type `scaling_modifier` which is a class in one of my projects.

It is an object with 3 attributes, a name, a type, and a modifier.
