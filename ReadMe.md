# Blazor Parallax

An example website that I thought was kinda cool, so now it's here ig?

That's really it..

---

## How it works
By surrounding the entire page with a `onmousemove`, a `MouseEventArgs` is sent to be processed in Blazor.
This is then used to get the position of the mouse relative to the page. Subtracting this by half the site
dimensions gets a value relative to the centre of the screen.

The site dimensions can't be found through blazor, so JS Interop is needed. The functions used in the 
JS Interop are found in [this file](./wwwroot/js/Parallax.js). 

From this, two CSS variables are modified through the HTML in the [index](./Pages/Index.razor). These are 
`--MouseX` and `--MouseY` on the `main` element. These variables are accessed by the CSS for the Parallax
elements, and this is the basis of the Parallax effect.

Then each individual image receives another two CSS variables, the `SpeedX` and `SpeedY` variables.
These contain multipliers to change how far the image moves in accordance with the Parallax effect.

To move the images with a Parallax effect, they must be moved in a way that creates depth. CSS handles this
with the variables mentioned previously. The images are all the same size in pixels, so they are centred