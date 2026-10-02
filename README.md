# DesignPatterns
# 1. State Pattern
State pattern is a behavioral pattern, where an object changes its behavior when changes its internal state. Every state is implemented separately.

<img width="645" height="280" alt="image" src="https://github.com/user-attachments/assets/f2db368e-c0d1-4c37-8926-f6e35fc1ec0d" />



# 2. Template Method
Template method provides an skeleton to implement an algorithm with a method (template method) where are listed all algorithm steps as abstract methods that are implemented in child classes.

<img width="618" height="427" alt="image" src="https://github.com/user-attachments/assets/2b06332b-af46-44a7-978b-1bfc4c43498d" />



# 3. Iterator Pattern
It is a mechanism to access all elements sequentially in an aggregate. An aggregate is an object that contains other objects. For example a list of objects.

<img width="776" height="487" alt="image" src="https://github.com/user-attachments/assets/7c70a211-f1e2-4bc1-b27a-53f0f625738c" />




# 4. Decorator Pattern
Decorator pattern is a design pattern that adds behavior to an object dynamically. It is composed of:
<ul>
<li>Component --> It is going to define common interface for components and decorators.</li> 
<li>ConcreteComponent --> Implements component interface and define basic object behavior. We can have many different concrete components.</li> 
<li>BaseDecorator --> Implements component interface and contains a reference to component.</li> 
<li>ConcreteDecorator --> Inherits BaseDecorator and adds extra behavior. We can have many different concrete decorators.</li> 
</ul>
<img width="780" height="582" alt="image" src="https://github.com/user-attachments/assets/1c580ae9-6e2f-4c5c-b560-944aa83b58e8" />



# 5. Façade Pattern
The Façade design pattern provides a unified interface for a set of interfaces in a subsystem hiding the complexities of the subsystem. The subsystem could a Framework, a library, a set of classes ...
<img width="592" height="292" alt="image" src="https://github.com/user-attachments/assets/51d11b22-e7eb-4233-a400-26fb383d4d47" />



# 6. Proxy Pattern
In proxy design pattern there is an object (proxy) that acts as intermediary with the real object. In the proxy object we can add extra functionality (control access, logging, caching ...) before or after every call to the real object.
<img width="657" height="385" alt="image" src="https://github.com/user-attachments/assets/f7cafc2b-42ad-4842-a7fb-1986db95c57d" />



# 7. Chain of Responsability Pattern
Chain of responsability pattern decouples the sender of the request from the receiver/s that can handle it. 
It behaves like a linked list where each element has a reference to the next element in the list. So, the element that can process the request, will process it. 
This pattern can also be implemented using events.

<img width="686" height="297" alt="image" src="https://github.com/user-attachments/assets/f25cc83e-0197-40f1-a9a6-5d86905729a2" />




