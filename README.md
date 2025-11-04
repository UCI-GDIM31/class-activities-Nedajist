# in-class-activities
## Devlogs
### W1
Hello World!

### W2
1. r, g, and b combine together to determine what color something is. If r, g, and b were booleans, there would only be 2 options (t/f) for each. 
That gives us only 2*2*2=8 possible colors, which is quite limiting. If r, g, and b were ints, that would give us many more colors, but the palette could still 
be expanded. Floats allow us to have a near infinite amount of possible colors to choose from, and colors can smoothly transition into others in tiny increments.

2. _bounce tracks the number of times the ball has bounced. A bool (true/false) will only tell us if the ball has bounced, not how many times it has bounced.
The ball can only have bounced a whole number of times - there is no half or quarter bounce - we do not need the decimals allowed by floats. The ball can only have bounced
have bounced a whole number of times, and int allows _bounce to be any whole number. 

3. The error I got in step 2 of part 2 informed me that I could not implicitly convert a double into a float. I knew r was a float, so
this told me that r+=0.1 was broken due to 0.1 being a double. In order to add 0.1 to r, I needed to set 0.1 as a float first. 


### W3
Table #16

As this method "doesn't need any output", it will be a void method with no return type.
The method's input is the player's sanity level, a number between 0 to 100%. If this is represented
as a whole number from 0-100, then the input type will be an integer. If, however, the sanity percentage
is represented as a number from 0.00 to 1.00, then the input type will be a float. 

A class is the blueprint for the room in a house. A component is a fully-built and realized blueprint for that room. Member variables are the dimensions 
and specifications of the room. Methods are the functionalities of the room (e.g., the door opens).

I think the balls get extremely bright because the brightness increase per bounce is tied to the ball's velocity, which is exponential. With every bounce, each
ball moves exponentially faster, causing their brightness levels to quickly reach extremes. 

### W4
Table #18

Line 17 creates a new member boolean variable (true/false) named _isGrounded. It is private, so it cannot be modified outside of its parent, the CatW4 class. This tracks if the player is on the ground.
Line 28 checks if the player has just pressed space and if they are also on the ground. Presumably this checks the conditions for a jump (the player has to be on the ground and pressing space)
Line 32 is within the if statement on line 28, and it sets _isGrounded to false. So when the player is jumping, they are counted as no longer on the ground.

I added Rigidbodies to the cat and the ball, since they physically collide with each other. Nothing collides with the goal, so I didn't add a Rigidbody to it.
I added is trigger to the goal, as it is supposed to detect collisions but not physically move/interact with colliders.
The game worked the first time I tested it.

### W5
Q: What is the difference between transform and Vector3?
A: A transform component contains several Vector3 variables. A Vector3 variable can never be a component.

The Deer W5 Class:
1. It needs a transform member variable and a NavMeshAgent variable.
2. The method required is Start.
3. The start method will set the NavMeshAgent variable and find the position of the transform variable.
   Then, the start method will call the NavMeshAgent's move method, prompting the deer to move.

### W6

Document Link: [Here](https://docs.google.com/document/d/1_Zwo3XH1VQM32Ym-pGFQQy0nj1sO6sBX9mo0lAvqYQw/edit?tab=t.0)
Category: Unity Coding

Plans for BatW6 class:
It will have 3 member variables: speed, an integer which determines how fast the bat moves. chasing_player, a boolean that determines 
if the bat will chase the player, and target_player, which is a gameobject that references to the player character.

I plan to make 2 custom methods, chase_player() and stop_chasing_player() which set chasing_player to true and false.
The bat will probably move in Update(), which I plan to retrieve the vector from the bat to the player, 
normalize it, and multiply it by Time.delta.time. Then I would transform the player's position by that new vector. 

Start() is only necessary for part 1, which will call chase_player(). 

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 