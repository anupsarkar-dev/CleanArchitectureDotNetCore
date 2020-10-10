![](https://miro.medium.com/max/1200/1*EN-joV0Cr_gMn8aX06iHNQ.jpeg)
### Clean Architecture .NET Core

What is Clean Architecture?
Does your code has following problems?
1. Produce bugs often
2. Debugging and/or adding new features is painful
3. Cannot write tests without database/ web server
4. Other developers cannot understand the intent of the code
5.has presentation logic mixed with business logic or business logic mixed in with data access logic

Congratulations! you write bug laden code!, wait.. so there’s no solution for that? Well.. all you have to do is follow best practices. Like SOLID or any other design pattern. They all have the same objective, which is the separation of concerns. They all achieve this separation by dividing the software into layers. Each has at least one layer for business rules, and another for interfaces.

The secret to building a large project that is easy to maintain is this: separating the files or classes into components that can change independently of other components. Let’s illustrate that with a couple of images.

![](https://miro.medium.com/max/821/1*aLKYPHKhmKbUdiFrz9fzyA.png)

In image (a), if you want to replace the scissors with a knife, what do you have to do? Needless to say that it is a hectic job. In image (b), how do we replace the scissors? We only have to pull the scissors’ string out from under the Post-it notes and add a new string that is tied to a knife. Way easier. The Post-it notes don’t care because the string wasn’t even tied to it.

The architecture represented by the second image was obviously easier to change. The key rule behind Clean Architecture is exactly this, or more technically, the Dependency Rule, which states that source code dependencies can only point inwards. So what does this mean? Take a look.

![](https://miro.medium.com/max/772/0*rC73pf-iEz-N7vLN.jpg)

 Nothing in an inner circle can know anything at all about something in an outer circle. In particular, the name of something declared in an outer circle must not be mentioned by the code in the an inner circle. That includes, functions, classes. variables, or any other named software entity. The gist of this is simply that dependencies are encapsulated in each “ring” of the architecture model and these dependencies can only point inward.
 
Entities : Encapsulate enterprise wide business rules.
An entity is a set of related business rules that are critical to the function of the application. In an object oriented programming language the rules for an entity would be grouped together as methods in a class. Even if there were no application, these rules would still exist.

For example, charging 10% interest on a loan is a rule that a bank might have. This would be true whether the interest was calculated on paper or using a computer. The entities know nothing of the other layers. They don’t depend on anything. That is, they don’t use the names of any other classes or components that are in the outer layers.

## ASP.NET Core Architeture 
![](https://miro.medium.com/max/1375/0*bfqz7CdZ6v4dCCgN.png)




[Full Article First Part Link  Here](https://medium.com/nishancw/clean-architecture-net-core-part-1-introduction-e70e1c49ef6) 
[Full Article 2nd Part Link  Here](https://medium.com/nishancw/clean-architecture-net-core-part-2-implementation-7376896390c5) 
Article Credit Goes To : Nishan Chathuranga Wickramarathna

If you want to go further from this I recommend you watch this video by [JASON TAYLOR](https://jasontaylor.dev/) or read his amazing article on [Clean Architecture](https://jasontaylor.dev/clean-architecture-getting-started/).


