# Unity2DPlatfromer
视频学习：https://www.udemy.com/course/unityplatformer
学习的记录，有相同学习经验的同学可以参考指正

此处为按集记录学习的内容，方便自己复盘
001 Introduction
004 Introduction To Unity
005 Setting Up Project & Importing Assets
以上几集都为基础，跳过。

006 Adding Player
添加player，pixel per unit，spirit editor切分多个spirit。

007 Sorting Sprites with Layers
008 Giving Player Physics
009 Creating a Script
010 Moving The Player
011 Jumping
012 Improving Gameplay Feel
013 Stop Unlimited Jumping
014 Adding Double Jump
015 Animating The Player
016 CHALLENGE - ANIMATE RUN & JUMP
017 Switching Animations
018 Controlling The Animator Through Code
019 Changing Direction
020 Camera Control
021 Adding Parallax for Depth
022 Clamping Camera Vertically
023 CHALLENGE - PARALLAXING VERTICALLY
移动远景和中景的y，主要的思路和相机移动x一致，只是把一维的float变成二维的vector。

024 Creating a Tile Palette
创建新level（new scene），tile map system。

025 Drawing a Level With Tilemaps
用tile map system绘制level；tilemap collider使地图拥有碰撞能力；composition collider让分散化为整体，设置为多边形免得玩家卡住；ridgidbody的bodytype为kinematic使其时空固定。

026 Moving Objects Between Levels With Prefabs
使用Prefabs，复用player、mainCamera和BG。

027 Adding Spikes
添加地形伤害，设置碰撞体，设置为触发器。

028 Creating a Health System
设置最大生命值、当前生命值，编写处理伤害函数（扣血and是否已无生命值），血已经扣完了就setActive(false)。

029 Detecting Spikes Hitting The Player
检测player与spike碰撞，采用重写unity函数方法。

030 Damaging The Player
将玩家health系统修改成单例，在spike的碰撞函数中将调试用的log方法改为调用health系统（单例）中的dealDamage。

031 Setting Up Health UI
032 Updating Health UI
033 CHALLENGE - SHOWING HALF HEARTS
034 Adding Invincibility
035 Displaying Invincibility
036 Adding Knockback
037 CHALLENGE - ADD HURT ANIMATION WHEN PLAYER IS HIT
038 Making Checkpoints
039 Deactivating Checkpoints
040 Storing Spawn Position
041 Respawning The Player
042 CHALLENGE - KILL THE PLAYER OUTSIDE HEALTH SYSTEM
043 Collecting Gems
044 Health Pickup
045 Adding Gems To UI
046 Adding a Pickup Effect
047 Showing Player Death Effect
048 Creating Our First Enemy
049 Setting Up Movement
050 Moving The Frog
051 Adding Pauses
052 Animating Enemy Movement
053 Editing Animation Curves
054 Defeating Enemies
055 Bouncing On Enemy
056 Dropping Health Pickups
057 Making Enemy Hurt The Player
058 Playing Sound Effects
059 CHALLENGE - ADD SOUND EFFECTS
060 Adjusting Sound Effects
061 Adding Music & Audio Mixing
062 Creating a Title Screen
063 Making The Menu Work
064 Doing a Test Build
065 Laying Out Pause Menu
066 Pausing The Game
067 Fixing Pausing Issues
068 Adding a Fading Black Screen
069 Setting up Level Ending
070 Making the Level End
071 Creating a Reusable Level Pack
072 CHALLENGE - MAKE TWO LEVELS
073 Setting Up The Level Select Map
074 Creating Map Points
075 Moving Around Level Select Screen
076 Following The Players Movement
077 Loading Levels
078 Adding Locked Levels
079 Unlocking Levels
080 Displaying Level Names
081 Showing Gems Earned & Time Played
082 Saving Gems Earned & Time Played
083 Only Saving Best Gems & Time
084 Showing Badges
085 Loading To Correct Point
086 CHALLENGE - ADD SOUND TO OVERWORLD
087 Switching Music On Level End
088 Add continuing to Title Screen
089 One Way Platforms
090 Moving Platforms
091 Keeping Player On Moving Platform
092 Setting Up Flying Enemy
093 Attacking The Player
094 CHALLENGE - MAKE THE FLYING ENEMY HURT THE PLAYER
095 Bounce Pad
096 Adding a Switch
097 FINAL CHALLENGE - ADD A SLAMMER
098 Setting Up the Boss with Animations
099 Setting up The Boss Basics
100 Creating a State Machine
101 Switching States
