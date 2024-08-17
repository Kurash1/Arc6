Arc6 includes a range of primitive types to support various kinds of data manipulation and operations. Below is a detailed description of each primitive type available in Arc6.

Arc6 has 3 number primitives:
	`integer` for whole numbers
 	`float` for decimal numbers
  	`boolean` for true(1) false(0) states.

The `code` primitive is used to store any and all forms of code.
```
{
	add_treasury(500)
}
```

The `function` primitive is used to store functions
```
new function add_treasury = {
	args = int
	add_treasury = args
}
```
The `modifier` primitive is used to store modifiers
```
{
	global_tax_modifier = 20%
}
```
