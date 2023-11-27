# Purpose and Background of this Branch
Welcome to the _007th_ branch of this repository, carefully crafted to serve as a testament to my progress and achievements in the fascinating realm of learning C#. As I traverse the landscape of programming, this branch stands as a milestone, displaying a task that I've earnestly tackled and conquered.

## Unveiling the Task
Delve into the contents of this branch, and you'll encounter a meticulously designed task, beckoning for your exploration and engagement. This task, presented with the intriguing title "The Defense of Consolas," is an opportunity for hands-on experience and learning within the realm of C#.

## The Defense of Consolas: An Overview
Let's shine a spotlight on the task at hand. The Defense of Consolas is not merely an exercise but a journey into the intricacies of coding and problem-solving. As you peruse the contents of this branch, you'll find a task description that beckons you to immerse yourself in the challenges it presents.

Feel free to open and edit this task, navigating through the code and concepts interwoven within. This is not just a task; it's an invitation to enhance your C# proficiency and engage in the artistry of programming.

## Significance in the Learning Odyssey
Every branch in this repository tells a unique story, and the _007th_ branch is no exception. It signifies a chapter in my ongoing saga of mastering C#, where each line of code, every challenge, and solution contributes to the evolving narrative of my computer science education.

So, whether you're a fellow coder, a curious learner, or a programming enthusiast, I invite you to explore, experiment, and appreciate the intricacies embedded in the Defense of Consolas within this branch. May this task be a stepping stone in your own journey of discovery and mastery in the world of computer science.

Feel free to reach out if you have any questions or insights as we navigate the vast landscape of programming together. Happy coding!

## Task description
The Uncoded One has begun an assault on the city of Consolas; the situation is dire. From a moving airship called the Manticore, massive fireballs capable of destroying city blocks are being catapulted into the city.
The city is arranged in blocks, numbered like a chessboard.
The city's only defense is a movable magical barrier, operated by a squad of four that can protect a single city block by putting themselves in each of the target's four adjacent blocks, as shown in the picture to the right.
For example, to protect the city block at (Row 6, Column 5), the crew deploys themselves to (Row 6, Column 4), (Row 5, Column 5), (Row 6, Column 6), and (Row7, Column 5).

The good news is that if we can compute the deployment locations fast enough, the crew can be deployed around the target in time to prevent catastrophic damage to the city for as long as the siege lasts. The City of Consolas needs a program to tell the squad where to deploy, given the anticipated target. Something like this:
```c#
Target Row? 6
Target Column? 5
Deploy to:
(6, 4)
(5, 5)
(6, 6)
(7, 5)
```

### Objectives
 1. Ask the user for the target row and column.
2. Compute the neighboring rows and columns of where to deploy the squad.
3. Display the deployment instructions in a different color choosing.
4. Change the window title to be "Defense of Consolas".
5. Play a sound when the results have been computed and displayed.