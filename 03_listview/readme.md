# Render a Collection of Data Using The ListView and TextCard Classes

## Overview

In this exercise, you will use controls designed to render collections to render a list of simple items. Once you have rendered this list, you will be able to modify the appearance of these items using an ItemTemplate.

## Objectives

- Create a new C# class named **TodoItem** that represents items in a to-do list
  - Add a *string* property named **Id**
  - Add a *string* property named **Text**
- Create a new instance of the **ListView** class
  - Set the **ItemsSource** property of the *ListView* instance to a collection of fake
- Create an **ItemTemplate** for your *ListView* instance
  - Within the *ItemTemplate* instance, use an instance of the **TextCard** class to render the *Text* and *Id* properties of each *TodoItem* in your collection
  
### Support

Here is some sample to-do items that you can use in your code:

```c#
List<TodoItem> todoItems = new List<TodoItem>
{
  new TodoItem { Id = "0001", Text = "Original Task" },
  new TodoItem { Id = "0002", Text = "Follow-up Request" }
};
```

## Solution

[View Solution](solution.md)
