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

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 