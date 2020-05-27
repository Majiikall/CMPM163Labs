# CMPM163Labs
Maxfield's labs for CMPM163.
======================================================

LAB2
______________________________________________________

LINK: https://drive.google.com/file/d/1AMxvzFnKDHyJJ4zqoVVR-dEScwDJUxTJ/view?usp=sharing

![](lab2/media/part%202%20screenshot.png)

<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

LAB3
______________________________________________________

LINK: https://drive.google.com/file/d/1l4LvTCWn5QJcAyDzdOpuMqMnqjbkG39c/view?usp=sharing

The Cube on the left I changed by taking the input values for the fragment shader and updating them in animate()
to create a gradient effect that would constantly update the colors in a unique way. 
The cube in the middle is the initial cube created in the lab using the Phong Material. The right cube is the first
cube made with the original shader from the lab. The top cube is made using the Lambert Material.

<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

LAB4
______________________________________________________

LINK: https://drive.google.com/file/d/1TowNSrt8m5_74xA1FSfjt8KJxOM2YkzM/view?usp=sharing

24a; x = floor(7u).

24b; y = floor(-7v+7).

24c; x= floor(7*.375) => 2 
     y= floor(-7*.25 + 7) => 5
     Sample from (2, 5) and the color is Grey.
     
Cubes- The middle cube is the original cube with texture that was done in part1 of the lab. I used 156.jpg as my texture for that cube and also added the normal map to improve the overall quality of the texture. The cube on the left is the second cube created in part 1 of the lab, this uses the same texture and map from the first cube but it is an actual cube and based on my oscilating light animation it shows the texture from different perspectives. The cube on the right is the first cube done in part 2 using the texture but having it come from the vertex and fragment shaders. The top cube is the cube using the sampler and the new texture to display itself. This was done based on the first cube using the v and f shaders but instead they were done in the HTML code itself. The final cube, the bottom, is the tiled cube. To make this cube tiled in a 4x4 grid I first casted a vec2() to my texture2D function call. Doing this I then used mod(vUv, 0.25) to sample 4 cubes across the texture. Next I multiplied that value by 4.0 to properly scale the rows and get the correct result.

<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

LAB5
_____________________________________________________
LINK: https://drive.google.com/file/d/1gn6xCDIBWN1ZxIlSILjKwyOYcKIaEUeI/view?usp=sharing

In this section of the Lab I did the section related to Unity. For this I added some new features to the cart game. I changed the material of the driver to be something checkered and different from the original. I manipulated the material of the track as well, adding rainbow sections, jumps, lap checkpoints and bowling pin obstacles. I also added two particle emitters to the cart for added effects. Next I changed the skybox and the light gradient and then added a spotlight above the cart to see the driver better. Finally, I added a celebration for the finish and start of the race that is triggered when passing through a trigger. 

<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

LAB6
_____________________________________________________

![](lab6%20media/Lab6%20SC.png)

Link to my shader with circle effect and everyline commented: https://www.shadertoy.com/view/3sSfRR

Link to a cool project: https://www.shadertoy.com/view/ls3BDH

<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

LAB7
______________________________________________________

Link: https://drive.google.com/file/d/1Knk7g9kL2n_cv1S2vSnQAnai7F_2c3kO/view?usp=sharing

For this part of the lab I used two planes to create snow covered mountains for the mountain range. Next I created the wave below the mountains to make it look like it could be an alpine lake. Finally, I wrote a short script to move some of the spheres created in the first tutorial to make them function as clouds for the project. 

For the partner check in I was unable to contact them.

<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

LAB8
______________________________________________________
Here is the screenshot from finishing the tutorial in UNITY for the lab
![](lab8/lab8%20SC.png)

Below is the image I drew inspiration from for this project:
![](lab8/MSM.jpg)

Here is the link to my final procedurally generated city for the lab: https://drive.google.com/file/d/1gC3L4VbTX5Q8xWLRPKLlUq_j3xirHo0F/view?usp=sharing

For this portion where I added my own parts I first created an ocean to mimic an island. This ocean was using textures from the asset store and then I added a dirt feature that would appear under the city since the buildings can't float. Next I added a feature to the code that tiers the placement of the procedurally generated city to make it look like it's on a hill. This was to mimic Mont Saint-Michel from my inspiration. Finally, I added a church to the top of the island to top it off.

My partner and I did not work together and we did not share answers to the questions. When I was contacted they were already finished and I was not close to completing the lab. 
