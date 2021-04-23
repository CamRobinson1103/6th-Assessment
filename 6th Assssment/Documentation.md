| Cameron Robinson|
| s208065|
| Game Programming |
| Unity Assessment Documentation |

## I. Requirements

1. Description of Problem

	- **Name**: Unity Assessment

	- **Problem Statement**: Check all the requirments for Assessment
	
	- **Problem Specifications**:  
    

2. Input Information
- Left mouse click = Move player left
- Right mouse click = Move player right


### Object Information


**File**: GameManager.cs

**Attributes**

         Name: EndGame()
             Description: Restarts the game after the player collides with an obstacle
             Type: public void
         Name: Restart()
             Description: Sets the player at their beginning position
             Type: void
      
**File**: Player.cs

**Attributes**

         Name: OnCollisionEnter(Collision collision)
             Description: Either sets the player at the beginning position of they collide with an obstacle
			  or closes the application when they hot the finish line
             Type: void

        

**File**: VLineBehavior.cs

**Attributes**

         Name: OnCollisionEnter(Collision collision)
             Description: Closes the game when the player collides with it
             Type: void
        

**File**: CameraBehavior.cs

**Attributes**

         Name: Update()
             Description: Positions the camera behind and above the player
             Type: void
         
**File**: PlayerMovementBehavior.cs

**Attributes**

         Name: Update
             Description: These are the controls to move the player left or right
             Type: void
        