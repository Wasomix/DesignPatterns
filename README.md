# DesignPatterns
# 1. State Pattern
State pattern is a behavioral pattern, where an object changes its behavior when changes its internal state. Every state is implemented separately.

<img width="645" height="280" alt="image" src="https://github.com/user-attachments/assets/f2db368e-c0d1-4c37-8926-f6e35fc1ec0d" />



# 2. Template Method
Template method provides an skeleton to implement an algorithm with a method (template method) where are listed all algorithm steps as abstract methods that are implemented in child classes.

<img width="618" height="427" alt="image" src="https://github.com/user-attachments/assets/2b06332b-af46-44a7-978b-1bfc4c43498d" />



# 3. Iterator Pattern
It is a mechanism to access all elements sequentially in an aggregate. An aggregate is an object that contains other objects. For example a list of objects.

<img width="801" height="487" alt="image" src="https://github.com/user-attachments/assets/ec0e454c-f642-4003-850a-6916ea6c5ee5" />


# 4. Decorator Pattern
Decorator pattern is a design pattern that adds behavior to an object dynamically. It is composed of:
<ul>
<li>Component --> It is going to define common interface for components and decorators.</li> 
<li>ConcreteComponent --> Implements component interface and define basic object behavior. We can have many different concrete components.</li> 
<li>BaseDecorator --> Implements component interface and contains a reference to component.</li> 
<li>ConcreteDecorator --> Inherits BaseDecorator and adds extra behavior. We can have many different concrete decorators.</li> 
</ul>
