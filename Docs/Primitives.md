Arc6 includes a range of primitive types to support various kinds of data manipulation and operations. Below is a detailed description of each primitive type available in Arc6.

Arc6 has 3 number primitives:

`integer` for whole numbers
 
`float` for decimal numbers
  
`boolean` for yes(1) no(0) states.

The `code` primitive is used to store any and all forms of code. `trigger` and `effect` are aliases for the `code` primitive.
```
{
	add_treasury(500)
}
```

The `modifier` primitive is used to store modifiers
```
{
	global_tax_modifier: 20%
}
```

The `object` primitive

The `list<T>` primitive

The `dict<T>` primitive

The `string` primitive

The `enum` primitive
```
{
	effect
	trigger
}
```

The `null` primitive

The `struct` primitive is used to define the structure of an object
```
{
	string: tag
}
```

The `class` primitive allows you to define named global variables
```
new class country: {
	list: countries
	attributes: {
		string tag
	}
	compile: {
		write_file("common/country_tags", {
			foreach country in countries {
				country:tag
			}
		})
	}
}
```
