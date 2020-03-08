(*** raw ***)
---
layout: page
title: Why I like functional programming (with an F# bias)
---

(**
## My background as a developer

While I would consider myself to be of above average intelligence in certain areas, programming is not one of them.
I would say that I am competent but nothing spectacular.

As such I have been able to identify a few areas, in no particular order,
where I have been lacking and which are ultimately relevant to why I now prefer functional programming as opposed to OOP.

- Weak basics and hacking mentality
- Dealing with complexity and accidental complexity in particular
- Tunnel vision
- Arrogance

I got started with programming at a fairly late stage and my exposure to it was mainly during my university days.

During that time, I hated it because I am not a natural for reasons I attribute to the areas I listed above.

As part of my engineering course, I came across programming and really we only had a couple of courses on high level
programming and I did struggle with it.

Hence, as it is only human, I neglected it and only did the bare minimum.

I would hack away at code until I would get the desired result and that would be it.

However after I took six months out in industry as part of my course, I came to the realisation that I would have
to improve my programming skills.

As a result, I went to the [University of Kent at Canterbury](https://www.kent.ac.uk) on a Computer Science conversion
course very similar to this [one](https://www.kent.ac.uk/courses/postgraduate/243/computer-science).

This was a great programme whereby I learned a lot and my basics improved.

After that I started working as a developer mostly with Microsoft technologies and inevitably started using .NET and
I have been programming in C# for a fair few years now.

## How I came across F#

It was maybe 3 years ago that I had anything to do with F# and that was foisted upon me when I had to deal with [Fake](https://fake.build/).

Although it is claimed that it is easy easy for C# developers to pick up FAKE, it certainly was not my experience.

Therefore, I resisted it for a bit but then for a variety of reasons I had to understand FAKE better.

As a result, and having learned from my mistake about not getting solid basics, I started learning F# since FAKE is written using the latter.

## Why I like functional programming with F#

While I am still a novice, I much prefer functional programming (F#) to OOP (C#).

For me it boils down to 2 issues:

- language
- abstraction models

which are interlinked.

### Language

I never realised it before learning about functional programming, but the paradigms upon which a language is based upon
forces us to code in a certain way.

However what is more subtle and pernicious is that it also forces us to think a certain way which leads to us to writing complex code.

I have found that with C#, I have to fight with the language in order to do what I want to do as opposed to F#.
With the latter I am able to focus more on the business problem at hand.

As developers, we are not only required to code business logic, we are also meant to do so in a maintainable and readable way.

Hence, in the development world, we have come up with the SOLID principles, design patterns, DRY, etc to address the maintenance
and readability problem.

However, this is a problem in itself because this requires significant investment and practice.

For instance, when you first encounter the term "Strategy pattern" or "Liskov Substitution Principle",
it can be a real slog to stop what you're doing, try to figure the concepts and then applying these concepts.

Moreover, consider the Dependency Inversion Principle whereby in the world of C#, the reference is this [book](https://www.manning.com/books/dependency-injection-principles-practices-patterns)
by Steven van Deursen and Mark Seemann.
While it is a fine book, I find it quite incomprehensible that we have to spend so much time and effort to learn this in order to
address what I consider to be a language issue.

So in effect, we're introducing accidental complexity in order to compensate for language deficiencies.

### Abstraction models

This is an important one because we are talking about how we will model our solution to problem.

With OOP, we think in terms of Object which have state and behaviour while with functional programming we think in terms of functions.

This fundamental difference is very significant and this also somehow ties in to language.

One of the things that we do as programmers is that we come up with abstractions to structure our software and more often than not we
do it in an organic ad-hoc way.

There is no guarantee that our abstractions are correct and they are generally superficial.

However, there is a discipline which is very good with formalising and proving abstractions and that is mathematics,
and in particular, a branch of mathematics known as category theory.

The ideas of functional programming come from this discipline and hence why you have ideas such as pure functions i.e.
for a bounded set of inputs you always have the same bounded set of outputs.

Hence functional programming builds upon a solid mathematical background in order to build predictable system.

I don't know about you but I much prefer to rely on the power of mathematics to write my system rather than relying on my own brain power.

Someone else has done the heavy lifting and I much rather take advantage of that.

## How functional programming helps with writing better systems

From a language level point of view, there are 2 big items

1. Composition
2. Algebraic sum types

### Composition
This is one which is a so called no-brainer.
We are often told to [favour composition over inheritance](https://en.wikipedia.org/wiki/Composition_over_inheritance).

Well since one of the pillars of OOP is inheritance, it would be fair to say that this main feature of OOP is forcing us
to code in a way that will make our application more complex.

However, in OOP to do composition often requires us to perform code gymnastics and learn and apply design patterns thereby
forcing us away from solving the business problem and instead come up with abstractions to compose our application.

With programming based upon functional principles, composition is much easier as it is usually built into the language.

### Algebraic sum types

Ignore the term "Algebraic sum types" for a minute and consider that in programming, we often have to **model choices** that we can have.

The classic example that is often given is related to payment.

For instance, we can pay by
- Cash
- Credit Card
- Debit Card
- Bit coin

etc

In F# this is trivial but in C# there is significantly more code that we have to write in order to achieve the same thing.

So for instance in pseudo F# we would write
```
PaymentMethod
| Cash
| CreditCard
| DebitCard
| BitCoin
```

And a customer, again in pseudo F#, would be modelled as:

```
Customer{
  Name string
  Age int
  PaymentMethod PaymentMethod
}
```

Then when it came time to pay, we would simply extract the method of payment and based upon each of the latter we'd invoke a different code pathway.

```
Pay (PaymentMethod paymentMethod, amount decimal)
{
  if paymentMethod == Cash then
    PayByCash(amount)
  elseif paymentMethod == CreditCard then
    PayByCreditCard(amount)
  etc
}
```

Effectively, you have the "Strategy Pattern" built into the language.

These are but two of the features of functional programming which I have personally found have made my programming life much more enjoyable.

It's a bit like having to write tests. We often do this because we want to gain greater confidence that our code is doing what it's supposed to do.

However, in terms of business logic, the tests are not bringing any value in terms of functionality.

So if you could get away with not writing any test code and still have the same level of confidence in your code, then I am sure you would do so.

This is what I believe Algebraic sum types bring in functional languages such as F#.

----------------
With F#, I have found that I have better flow meaning that I am able to concentrate more on solving the business problem rather than
technical ones.

With F#, I have suitable building blocks with which I can compose together in a readable and maintainable way.

In fact, I have found that it's much easier and quicker to come back to legacy F# code as compared to C#.

Moreover with F#, I find myself writing less code in a more declarative fashion thanks to the many higher order functions available.

While there is certainly a learning curve to F#, I have found the concepts much more intuitive and straightforward than with C#.
*)
