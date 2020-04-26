# URP-AnimatedGrass
## An Animated Grass Shader for Blade-like Geometry [Unity URP]

A fully procedural animated shadergraph for making wavy grass that responds to one object 'wading' through it. Designed with unity 2019.3.10f1 and URP 7.3.1.

### Instructions
1. Clone the project and open the sample scene in Unity 2019.3.10f1 (or recent), with URP 7.3.1 (or recent)
2. The grass push while wading is made possible by the Playerpos script on the sphere. Make sure you're player has that script
3. Multiple Characters wading through grass can be achieved by duplicating the Grass push group in the graph and adding them to final comp
4. The shader is designed with URP but should be easy to port to HDRP by changing the master node (Untested for now)

## Demo Video

<a href="http://www.youtube.com/watch?feature=player_embedded&v=9eiiY_tHd4o
" target="_blank"><img src="http://img.youtube.com/vi/9eiiY_tHd4o/0.jpg" 
alt="Simple Clouds Video" width="240" height="180" border="10" /></a>
