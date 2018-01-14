# contributions
.NET Code Repository for Contributions to Knowledge Sharing

Ideally as a software engineer you try to live by the following tenets.

• Focus on quality, ensuring we can meet future deliverables, rapidly and reliably!!!
• Emphasis on substantive changes versus stylistic changes to the system.
• Simple, flexible design that utilizes modern “best practices and approaches”
• If the system is designed in a way currently and is functioning as expected, but a more modern approach or aspect to software design should be implemented FOR A BENEFIT, then refactor all similar areas into the same approach or technology to maintain standardization for all the benefits that standardization helps to provide future work. 
o     There should be a clear ROI and/or benefit to the re-working of functional areas!!
• “Feature Branching” the current source code to a new branch for changes. 
o Even the smallest changes should be done in a new separate “feature branch”
• Atomic changes to the source code!
o Produce work in atomic or modular parts that make up a whole of something. 
o Rolling back, forward, or cherry picking across branches is afforded a much easier go, if changes are made atomically and committed per its atomic behavior.
• Clear code commit commenting is important and has value.  It seems like a basic tenet of the SDLC but often gets overlooked or because of deadlines the importance of code commits is minimized. Try to not to minimize the significance of detailed code commit commenting. 
• COVER YOUR UNIT TESTS!  The first bullet is Focus on Quality.   Even the smallest of changes, a copy and paste bug, a missing quote or one iota can stand between you and success.  Again, cover your unit tests.   It doesn’t take that long to perform and can quickly become a friendly counterpart or helper to your development process.  Bugs are an unfortunate, but inevitable part of development, but with the level of unit tests in the system at the time of writing is over 90%, you can be more confident that your change did not have a negative consequence across the breadth of the code coverage.  
• Try to NOT commit code that has failed unit tests. 
o Look at why the test is failing and fix the module or the test if the underlying logic that the test used to check has changed.
o Ensure your assumptions match newer or changing business rules.
• Try to NOT modify tests just to get them to pass.  
o Unit testing is an important part of maintaining system quality, stability and reliability.  
• Code Freezes should seek to limit changes to branches after validation.
• Code Reviews will seek to enforce the previously mentioned constraints.

# initial scope
• Usage of Interfaces and through their implementations, are paramount, to simplifying future upgrades and to the current performance of the systems execution.   
• Unit testing compliance and code coverage threshold of no less than 80% will ensure future changes have less potential for a negative impact to the DC and for re-verification of completeness to spec / regression testing to be performed more thoroughly and quickly as compared to manually.
• Business or Domain Logic will be stored in a “Business Logic Layer” separated from Data Access the Service Layer or any future Presentation Layer.  In this way, we can provide for separation of concerns with implementations or “layers of the system”.
• If layers are tied together to tight or “tightly coupled”, then changes to the system in one area typically have an adversely affect or requires changes in the other, raising costs, risk and impact. The system quality and cost of future changes are also then put in question with further limits to the availability of options for future growth in both technology stacks and new updated frameworks and code approaches.  In short, separate your layers and provide simple interfaces.
• Using NuGet packages solely for the referencing of internal or external libraries not provided by the .NET framework.  This will help to limit DLL hell and encourage upgrading of components when manufacturers or distributors make upgrades to the libraries they support.
• Data Access Layer should maintain to ONLY CRUD data in this layer. 
o Minimize or remove “business rules”
• Data Access should try to be performed through the Repository pattern.
• Data not handled in memory should only communicated along a protocol, preferably https.
• Web Services or the “Service Layer” will allow for abstraction & provide separation of concerns between layers of DC architecture. Namely separating Data Access and providing simple data interfaces to clients and other parts of the system.
o The ESB for example is separated, isolated and agnostic to the implementation of Data Access and can communicate across globally distributed systems in real-time quickly and reliably using Web Services.
• Web Services are currently 
• Code First Migrations will be utilized to provide for a code driven structure to the data model and underlying data points from which the system depends.  This will allow for completeness of a data model to be self-contained in the source solution and allow for visibility to its changes.
• Encrypting sensitive configuration values that exposed could allow for misuse of a system.
• .NET C# is the current system language and all new modules and components should seek to use the same runtime / framework version. 
• Create Unit tests in ways that provide both positive “Expected” checks and negative “Unexpected” checks. A common TDD rule of thumb is red-green refactor. 
• Pass interfaces around… try to not pass around Concrete implementations.  Think IoC!! 
