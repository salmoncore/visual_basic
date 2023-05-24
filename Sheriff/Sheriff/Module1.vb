Module Module1

    Dim transitionTimer As New System.Timers.Timer
    Dim drawTimer As New System.Timers.Timer

    Dim transitionText As String
    Dim drawText As String
    Dim tCount As Integer
    Dim dCount As Integer
    Dim tEnd As Integer
    Dim dEnd As Integer

    Dim c As Integer

    Dim Input As String

    Dim Scene As Integer = 1
    Dim Running As Boolean = True

    Sub Main()

        transitionTimer.AutoReset = True
        transitionTimer.Interval = 3000 '3-6 seconds
        AddHandler transitionTimer.Elapsed, AddressOf transitionTick

        drawTimer.AutoReset = True
        drawTimer.Interval = 100
        AddHandler drawTimer.Elapsed, AddressOf drawTick

        'My.Computer.Audio.Play(My.Resources.gbu16, AudioPlayMode.Background)

        Console.WriteLine("Text Speed Setting")
        Console.WriteLine("1) Fast Text Writing   2) Normal Text Writing   3) Slow Text Writing")
        Console.Write("Your Selection: ")
        Input = Console.ReadLine

        If Input = "1" Then
            transitionTimer.Interval = 3000

            Console.Clear()
        ElseIf Input = "2" Then
            transitionTimer.Interval = 4500

            Console.Clear()
        ElseIf Input = "3" Then
            transitionTimer.Interval = 6000

            Console.Clear()
        Else
            transitionTimer.Interval = 2000
            Sass()
            Console.Clear()
        End If

        Console.Clear()

        Title()

        Console.Read()
    End Sub

    Sub Title()

        Console.Clear()

        My.Computer.Audio.Play(My.Resources.gbu16, AudioPlayMode.BackgroundLoop)

        c = 0

        While c = 0
            drawText = "                                                                     ()"
            dEnd = 1
            drawTimer.Start()
        End While

        While c = 1
            drawText = "          88                                88    ad88    ad88       /\"
            dEnd = 1
            drawTimer.Start()
        End While

        While c = 2
            drawText = "          88                                **   d8*     d8*    ()--'  '--()"
            dEnd = 1
            drawTimer.Start()
        End While

        While c = 3
            drawText = "          88                                     88      88       `.    .'"
            dEnd = 1
            drawTimer.Start()
        End While

        While c = 4
            drawText = ",adPPYba, 88,dPPYba,   ,adPPYba, 8b,dPPYba, 88 MM88MMM MM88MMM     / .. \"
            dEnd = 1
            drawTimer.Start()
        End While

        While c = 5
            drawText = "I8[   **  88P'    *8a a8P_____88 88P'   *Y8 88   88      88       ()'  '()"
            dEnd = 1
            drawTimer.Start()
        End While

        While c = 6
            drawText = " `*Y8ba,  88       88 8PP******* 88         88   88      88     "
            dEnd = 1
            drawTimer.Start()
        End While

        While c = 7
            drawText = "aa    ]8I 88       88 *8b,   ,aa 88         88   88      88     "
            dEnd = 1
            drawTimer.Start()
        End While

        While c = 8
            drawText = "`*YbbdP*' 88       88  `*Ybbd8*' 88         88   88      88     "
            dEnd = 1
            drawTimer.Start()
        End While

        While c = 9
            drawText = "                                                                "
            dEnd = 1
            drawTimer.Start()
        End While

        Console.WriteLine("                         PRESS ENTER TO START")
        Dim Temp As String = Console.ReadLine

        If Temp IsNot "" Then
            On Error GoTo heck
            Scene = Console.ReadLine
        Else
heck:
            Scene = 2
        End If

        My.Computer.Audio.Stop()

        Console.Clear()

        CharacterCreation()

    End Sub

    Sub Nxt()
        Console.WriteLine("==>")
        Console.ReadLine()
    End Sub

    Sub CharacterCreation()

        Console.WriteLine("While deep in slumber, you contemplate your life and all your groundbreaking acheivements.")
        Nxt()
        Console.WriteLine("What were they again...?")
        Nxt()

        Console.WriteLine()
        Console.WriteLine("CHOOSE A CLASS")
        Console.WriteLine("1) Famous Philosopher   2) Sucessful Businessman   3) Influential Politician")

        Console.ReadLine()

        Console.WriteLine("Oh! You remember now, you're a poor illiterate cowpoke.")
        Nxt()

        Console.WriteLine("Well! At least you're the most honest, dependable, hardworking buckaroo in this frontier.")
        Nxt()

        Console.WriteLine("Besides, you still have a chance to make history!")
        Nxt()

        Console.WriteLine("The town's last Sheriff was whisked away by a tumbleweed stampede,")
        Console.WriteLine("and gosh darn you just KNOW you'd be the best Sheriff there ever was.")
        Nxt()
        Console.WriteLine("Besides, with the tumbleweed infestation ruining crops and threatening livestock,")
        Console.WriteLine("the town will need someone around to keep the peace.")
        Nxt()

        Console.WriteLine("With a head full of hope on a pillow full of fluff, you drift back to sleep...")
        Nxt()

        Console.Clear()

        SleepScene()

    End Sub

    Sub Sass()

        c = 0

        While c = 0
            transitionText = "Well pardner,"
            dEnd = 1
            transitionTimer.Start()
        End While

        While c = 1
            transitionText = "seems we got off on the wrong foot here now ain't we."
            dEnd = 1
            transitionTimer.Start()

        End While

        While c = 2
            transitionText = "If memory does serve me as I believe it does,"
            dEnd = 1
            transitionTimer.Start()

        End While
        
        While c = 3
            transitionText = "you were instructed to simply enter a gosh durn text speed."
            dEnd = 1
            transitionTimer.Start()

        End While

        While c = 4
            transitionText = "Don't worry now stranger, I'll forgive you for this grievience you've committed."
            dEnd = 1
            transitionTimer.Start()

        End While

        While c = 5
            transitionText = "Seein' as you seem like a spicy cowpoke, I'll set the speed to EXTRA FAST for ya."
            dEnd = 1
            transitionTimer.Start()

        End While

        While c = 6
            transitionText = "Best mosey on now. Good luck among the willows, mutton-puncher."
            dEnd = 1
            transitionTimer.Start()

        End While

        While c = 7
            transitionText = " "
            dEnd = 1
            transitionTimer.Start()

        End While

        Console.Clear()

        Title()

    End Sub

    Sub SleepScene()

        Console.WriteLine("It's early morning, and you can hear your soon-to-be loyal citizens already up and about.")
        Nxt()
        Console.WriteLine("Get up?")

BrokePoint:
        On Error GoTo BrokePoint

        Console.WriteLine("1) Early bird catches the worm!   2) 5 more minutes...")
        Input = Console.ReadLine()


        If Input = "1" Then

            On Error GoTo BrokePoint
            Console.Clear()
            TownPlot()

        ElseIf Input = "2" Then
            Console.WriteLine("You decide to get some extra beauty rest.")
            Nxt()
            Console.WriteLine("After all, beauty is the cowboy's primary concern.")
            Nxt()
            Console.WriteLine("You doze off and fall asleep...")
            Nxt()

            Console.Clear()

            Console.WriteLine("It's now midday, and you can sure hear the townsfolk bustling around the streets.")
            Nxt()
            Console.WriteLine("What'll ya say, get up and start sheriff'in?")

BrokePoint2:
            On Error GoTo BrokePoint2

            Console.WriteLine("1) Of course!   2) Absolutely not!")
            Input = Console.ReadLine()

            If Input = "1" Then

                On Error GoTo BrokePoint2
                Console.Clear()
                TownPlot()

            ElseIf Input = "2" Then

                Console.WriteLine("As all cowboys tend to do, you decide to take the day off and sleep.")
                Nxt()
                Console.WriteLine("You're not too sure as to how cowboys get a lot done this way, but cowboys around here")
                Console.WriteLine("aren't known for their critical thinking skills, especially not you.")
                Nxt()
                Console.WriteLine("You once again get back to some peaceful shuteye...")
                Nxt()

                Console.Clear()

                Console.WriteLine("You can hear one heck of a a ruckus outside your hut, truly uncommon for this time of evening.")
                Nxt()
                Console.WriteLine("Go out and investigate?")

BrokePoint3:
                On Error GoTo BrokePoint3

                Console.WriteLine("1) Might as well...   2) No can do, it's sleep-o'-clock.")
                Input = Console.ReadLine()

                If Input = "1" Then

                    On Error GoTo BrokePoint3
                    Console.Clear()
                    TownPlot()

                ElseIf Input = "2" Then

                    Console.WriteLine("Of course, why even bother with what's going on outside?")
                    Nxt()
                    Console.WriteLine("You're doing a perfectly good job of Sheriff'in inside to begin with.")
                    Nxt()
                    Console.WriteLine("With that sound logic in mind, you get back to some snoozin'.")
                    Nxt()

                    Console.Clear()

                    Console.WriteLine("You wake up the next day with an empty belly and a dried up waterskin.")
                    Nxt()
                    Console.WriteLine("Hoping to trade the town currency of tumbleweed twigs for some provisions, you head outside.")
                    Nxt()
                    Console.WriteLine("Curiously, the town is empty and stripped clean of any resources, so you die of dehydration")
                    Console.WriteLine("before you find the answers you're looking for.")
                    Nxt()

                    Console.WriteLine("ENDING 1: SLEEPYHEAD")
                    Nxt()

                    Title()

                Else
                    GoTo BrokePoint3
                End If

            Else
                GoTo BrokePoint2
            End If

        Else
            GoTo BrokePoint
        End If

        'you start off in bed. you can get up or you can stay in bed. if you stay in bed, you sleep a few hours. 
        'you wake up a few hours later and have the option to rest again. you can go back to sleep for a few more hours.
        'you wake up even later and now it's almost nighttime. you can go all the way and sleep for the entire day.
        'if the user sleeps three times in a row, the entire day has gone by. the crops have been ruined, your cows have 
        'been eaten by wolves, your townspeople have left and you end up starving to death.

        'if you get up, you walk over to your window, put on your hat, grab your gun and badge, and head outside. 
        'the townsfolk are packing up and leaving on caravans. you stop one and ask where everyones heading.
        'the first guy speaks a buncha western garbage, which you can then ask him to simplify it, respond in similar
        'diction, or you can arrest the man for abandoning the town and abusing the english language.

    End Sub

    Sub TownPlot()

        Console.WriteLine("You hop out of bed, grab your unofficial Sheriff badge, holster your non-leathal beanshooter,")
        Console.WriteLine("and turn to the closet.")
        Nxt()
        Console.WriteLine("Since you're auditioning for the Sheriff position today, you have to look as spiffy as you can be.")
        Nxt()

BrokePoint:
        Console.WriteLine("What size hat should you wear today?")
        On Error GoTo BrokePoint

        Console.WriteLine("1) 1 microgallon cap   2) 10 Gallon Hat   3) 100 GIGAGALLON TACTICAL HEADGEAR")
        Input = Console.ReadLine()


        If Input = "1" Then

            On Error GoTo BrokePoint
            Console.WriteLine("No no no, that's pathetic. You're not even sure why you own such a baby cap.")
            Nxt()
            Console.WriteLine("If it wasn't entirely composed of water-hide, you'd probably burn it.")
            Nxt()

            GoTo BrokePoint

        ElseIf Input = "2" Then
            Console.WriteLine("Perfect, a proper size and weight, and it looks so great.")
            Nxt()
            Console.WriteLine("Better not poke it with a cattle prod, or it'll deflate.")
            Nxt()
            Console.WriteLine("You briefly contemplate giving up Sheriffing to become a rapper, but that genre of music")
            Console.WriteLine("hasn't been properly established yet.")
            Nxt()

            Console.Clear()

            Console.WriteLine("Now that you've got the right gear for the job, you're ready to head out.")
            Nxt()
            Console.WriteLine("You spin around and thrust your leg door-ward...")
            Nxt()

            TownTrouble()

        ElseIf Input = "3" Then

            Console.WriteLine("Using your immense COWBOY GRIT, you manage to lift the 100 GIGAGALLON TACTICAL HEADGEAR")
            Console.WriteLine("off of it's 100 GIGAGALLON TACTICAL HEADGEAR CONCRETE FOUNDATION GYROSCOPIC GROUNDING PLATE,")
            Console.WriteLine("which you paid a fortune to have installed.")
            Nxt()
            Console.WriteLine("Thankfully the hat was free, since nobody has ever sucessfully worn the hat without")
            Console.WriteLine("dying shortly afterwards.")
            Nxt()
            Console.WriteLine("You were DIFFERENT.")
            Nxt()
            Console.WriteLine("You had the TRUE COWBOY SPIRIT behind you.")
            Nxt()
            Console.WriteLine("You COULD equip this hat, you could face ANY CHALLENGE THROWN AT YOU.")
            Nxt()
            Console.WriteLine("You black out under the immense weight of the 100 GIGAGALLON TACTICAL HEADGEAR, and are crushed to death.")
            Nxt()

            Console.WriteLine("ENDING 2: 100 GIGAGALLON TACTICAL HEADGEAR")
            Nxt()

            Title()

        Else
            GoTo BrokePoint
        End If

    End Sub

    Sub TownTrouble()

        Console.WriteLine("WHAMM!!")
        Nxt()
        Console.WriteLine("Like a surgeon transplanting organs with a pickaxe, your art truly cannot be perfected further.")
        Nxt()
        Console.WriteLine("Thanks to your COWBOY ROUNDHOUSE KICK, you managed to kick the flimsy wooden side wall off,")
        Console.WriteLine("while leaving the door completely unscathed.")
        Nxt()
        Console.WriteLine("It probably also helped that you bolted the door down to the house's foundation with the bolts")
        Console.WriteLine("meant to secure the wall panneling. It's kept the pesky landlord from interrupting your SHERIFF")
        Console.WriteLine("TRAINING SESSIONS on multiple occasions.")
        Nxt()
        Console.WriteLine("You do wish he'd stop banging on that door every night, berating you with demands")
        Console.WriteLine("such as 'KEEP IT DOWN IN THERE' and 'WHERE'S THE RENT YOU'VE OWED ME'.")
        Nxt()
        Console.WriteLine("The nerve of some people.")
        Nxt()

        Console.Clear()

        Console.WriteLine("You leave your home, avoiding the impenetrable slab of spruce you used to call a door,")
        Console.WriteLine("and head out into town, where a great crowd is gathering around Town Hall.")
        Nxt()

        Console.WriteLine("You mosey your way through the crowd with your beanshooter at your hip and your unoffical")
        Console.WriteLine("Sheriff's badge on your lapel, straight to the stage where a stranger is speaking.")
        Nxt()
        Console.WriteLine("The townspeople seem nervious, insistently whispering nonsense into your ear as you pass.")
        Nxt()
        Console.WriteLine("'psst-- he'll do you in!'")
        Nxt()
        Console.WriteLine("'that there varmit's a killer!'")
        Nxt()
        Console.WriteLine("'would you be interested in purchasing a coffin before, or after your death?'")
        Nxt()
        Console.WriteLine("Above the hogwash, you hear the man shout:")
        Console.WriteLine("'ALL SHERIFF WANNABEES, BETTER STEP UP AND CLAIM THIS HERE STAGE FROM ME!'")
        Nxt()
        Console.WriteLine("You don't recall public speech as a part of today's Sheriff auditions.")
        Nxt()
        Console.WriteLine("You suppose the procedure for electing a new Sheriff must be difficult,")
        Console.WriteLine("especially with the tumbleweeds carrying off more peacemakers than ever.")
        Nxt()
        Console.WriteLine("The man on the podium points down at you and angrily beckons for you to come up.")
        Nxt()
        Console.WriteLine("Stranger: 'Oh, this is RICH. This kid's got his own badge and EVERYTHING.'")
        Console.WriteLine("Stranger: 'Why'don'ya come on up here and speak on the behalf of your town, Pardner?'")
        Nxt()

        Console.WriteLine("Think carefully, you're representing the town you were born and raised in.")
BrokePoint:

        Nxt()
        On Error GoTo BrokePoint

        Console.WriteLine("1) Go up and improvise   2) Prepare by writing notes   3) Perform the BRONCOBUSTER SQUAREDANCE")
        Input = Console.ReadLine()


        If Input = "1" Then

            On Error GoTo BrokePoint

            Console.Clear()

            Destiny()

        ElseIf Input = "2" Then

            On Error GoTo BrokePoint

            Console.Clear()

            Console.WriteLine("You reach for your pen and paper.")
            Nxt()
            Console.WriteLine("...But you don't have any.")
            Nxt()
            Console.WriteLine("You can't read, OR write.")
            Nxt()
            Console.WriteLine("That doesn't stop you from giving it a whirl.")
            Nxt()
            Console.WriteLine("After persuading the local businessman Bill Bargians to give up his")
            Console.WriteLine("pen and notepad, you then proceed to draw a crude stick figure punching a scribble,")
            Console.WriteLine("to remind you of what you set out here to do.")
            Nxt()
            Console.WriteLine("TO ENSURE THAT THE SWIFT HAND OF JUSTICE IS IMPOSED UPON THE LAWLESS TUMBLEWEEDS.")
            Nxt()
            Console.WriteLine("Satisfied with your ARTISTIC MASTERPIECE, you crumple it up and shove it into your hat.")

            GoTo BrokePoint

        ElseIf Input = "3" Then

            Console.Clear()

            Console.WriteLine("Of course, the BRONCOBUSTER SQUAREDANCE.")
            Nxt()
            Console.WriteLine("What a better way to present the culture of your humble town.")
            Nxt()
            Console.WriteLine("The stranger seems taken aback as you JUMP ONSTAGE, GRIP YOUR HAT, and PERFORM.")
            Nxt()
            Console.WriteLine("You perform the first stage of your dance, to thunderous applause.")
            My.Computer.Audio.Play(My.Resources.s1, AudioPlayMode.Background)
            Nxt()
            Console.WriteLine("Stranger: 'Okay pardner, those were some nice moves, but I'm gonna have to cut you off--'")
            My.Computer.Audio.Play(My.Resources.s2, AudioPlayMode.Background)
            Console.WriteLine("You relentlessly progress through the dance, as once it has begun, it cannot be stopped.")
            Nxt()
            Console.WriteLine("S: '...pardner, the jig is up. Literally. Stop dancing.")
            My.Computer.Audio.Play(My.Resources.s3, AudioPlayMode.Background)
            Console.WriteLine("But the jig is not up. It cannot be stopped. Only an act of god can save them now.")
            Nxt()
            Console.WriteLine("The stranger draws his Long Iron, and you face him directly, continuing the ritual.")
            Nxt()
            Console.WriteLine("There is no life.")
            Console.WriteLine("The stranger's grip tightens on the gun.")
            Nxt()
            Console.WriteLine("There is no death.")
            Console.WriteLine("The stranger rests his finger on the trigger.")
            Nxt()
            Console.WriteLine("There is only...")
            Console.WriteLine("S: 'I'M WARNIN' YOU...'")
            Nxt()

            My.Computer.Audio.Play(My.Resources.s4, AudioPlayMode.Background)

            Console.WriteLine("... THE BRONCOBUSTER SQUAREDANCE.")

            Console.WriteLine("ENDING 3: KILLER MOVES")
            Nxt()

            Title()

        Else

            GoTo BrokePoint
        End If

    End Sub

    Sub Destiny()

        Console.WriteLine("You see your good amigo Dan Westplains among the crowd, who immediately runs up to you")
        Console.WriteLine("and starts tugging at the badge in a sort of frenzy.")
        Nxt()
        Console.WriteLine("Dan: BY JIMINY, GET THAT THING OFF A' YOU!")
        Nxt()
        Console.WriteLine("Little did he know, you were prepared for the day in which someone would try to discredit")
        Console.WriteLine("your authority as a Sheriff, even if you were never one to begin with.")
        Nxt()
        Console.WriteLine("Your badge is secretly PERMANENTLY GLUED onto your shirt, as you melted down all")
        Console.WriteLine("the needles and pins you had in order to forge such a convincing counterfeit badge.")
        Nxt()
        Console.WriteLine("SHERIFF: Hands off the badge, Dan. I've got a date with destiny.")
        Nxt()

        Console.WriteLine("You stroll your way onto the stage and take the podium.")
        Nxt()
        Console.WriteLine("SHERIFF: 'Well, howdy everyone.'")
        Nxt()
        Console.WriteLine("S: 'Nice to meet y'all.'")
        Nxt()
        Console.WriteLine("S: 'Sheriff's the name, Sheriff'in's the game.'")
        Nxt()
        Console.WriteLine("S: 'I'm here to keep the peace, and gosh darn it I'll do anything")
        Console.WriteLine("to keep this beautiful little town of ours safe.'")
        Nxt()
        Console.WriteLine("S: 'We have tough times ahead of us, what with all the tumbleweeds sweepin' places off the map.'")
        Nxt()
        Console.WriteLine("S: 'But we've delt with worse, heck, remember when the last Sheriff had to drive that no-good raider out?'")
        Nxt()
        Console.WriteLine("The crowd looks uneasy.")
        Nxt()
        Console.WriteLine("The stranger, too, looks uneasy.")
        Nxt()
        Console.WriteLine("S: 'C'mon, y'all remember that lame greenhorn who was kickin and screamin?'")
        Nxt()
        Console.WriteLine("Stranger: 'ahem.'")
        Nxt()
        Console.WriteLine("S: 'Swearing revenge and puttin hexes on this here humble town like a lunatic?'")
        Nxt()
        Console.WriteLine("Stranger: 'A H E M.'")
        Nxt()
        Console.WriteLine("S: '...Well, what's the matter with you?'")
        Nxt()
        Console.WriteLine("The stranger - who is also the raider - is fuming in his oversized 15 gallon hat.")
        Nxt()
        Console.WriteLine("S: '...'")
        Nxt()
        Console.WriteLine("S: 'Oh. I see now.'")
        Nxt()

        On Error GoTo BrokePoint


        Console.WriteLine("Now's your time to shine, how do impose the law of the land on this interloper?")
        Nxt()


        Console.WriteLine("1) COWPUNCHER JUSTICE   2) Show mercy and allow him to leave   3) Do something completely unexpected")
        Input = Console.ReadLine()
BrokePoint:

        If Input = "1" Then

            On Error GoTo BrokePoint

            Console.Clear()

            Console.WriteLine("There's nothing you hate more than a lawless renegade.")
            Nxt()
            Console.WriteLine("Not tumbleweeds, not weedtumbles, or tumweedbles.")
            Nxt()
            Console.WriteLine("Not even those dried up shrubs that blow around in the wind.")
            Nxt()
            Console.WriteLine("Whatever those are called.")
            Nxt()
            Console.WriteLine("None of that stuff even comes CLOSE to the feel of hatred you have for people like this raider.")
            Nxt()
            Console.WriteLine("You begin foaming with rage, BOILING with hatred.")
            Nxt()
            Console.WriteLine("Before the raider even has time to flinch, you draw your pistol and hit him right between the eyes.")
            Nxt()
            Console.WriteLine("The crowd recoils from the bang of the gun, but look back up and start cheering.")
            Nxt()
            Console.WriteLine("The raider is laying on the ground, still conscious.")
            Nxt()
            Console.WriteLine("He accepted his fate, there and then.")
            Nxt()
            Console.WriteLine("He was ready for judgement, to pay for all the sins he had committed during his life.")
            Nxt()
            Console.WriteLine("He closed his eyes, waiting to fall into a dark, dreamless sleep.")
            Nxt()
            Console.WriteLine("But it didn't come.")
            Nxt()
            Console.WriteLine("He opened his eyes, and got on his knees, feeling his forehead.")
            Nxt()
            Console.WriteLine("A single kidney bean was on the ground in front of where he was shot.")
            Nxt()
            Console.WriteLine("He glanced over to see the Sheriff, twirling his trademark non-lethal beanshooter, smiling at the crowd.")
            Nxt()
            Console.WriteLine("For a moment, he was relieved.")
            Nxt()
            Console.WriteLine("He had another chance at life. He could redeem himself.")
            Nxt()
            Console.WriteLine("He could find love.")
            Nxt()
            Console.WriteLine("But then he realized he was shot by a man with a gun that shoots beans.")
            Nxt()
            Console.WriteLine("He decided that perhaps,")
            Nxt()
            Console.WriteLine("he could commit one more sin.")
            Nxt()
            Console.WriteLine("And he did.")
            Nxt()

            Console.WriteLine("ENDING 4: BEAN-FORCE TRAUMA")
            Nxt()

            Title()

        ElseIf Input = "2" Then

            On Error GoTo BrokePoint

            Console.Clear()

            Console.WriteLine("Sheriff: 'Hey there, what I said was awful rude, wansn'it?'")
            Nxt()
            Console.WriteLine("S: 'How about we make amends, true pals till the end?'")
            Nxt()
            Console.WriteLine("Raider: 'Sure.'")
            Nxt()
            Console.WriteLine("S: 'Really?!'")
            Nxt()
            Console.WriteLine("The crowd looked heartwarmed, tears were shed at the sight at such beautiful peacemaking.")
            Nxt()
            Console.WriteLine("R: '...'")
            Nxt()
            Console.WriteLine("R: 'No, I changed my mind.'")
            Nxt()
            Console.WriteLine("S: '...huh?'")
            Nxt()
            Console.WriteLine("R: 'I don't really want anyone here to survive.'")
            Nxt()
            Console.WriteLine("S: '...But I offered you mercy.'")
            Nxt()
            Console.WriteLine("R: 'Yeah.'")
            Nxt()
            Console.WriteLine("S: 'So this is the part where you'd spare the town as well.'")
            Nxt()
            Console.WriteLine("R: 'Oh. Yeah, I'm just not feeling it.'")
            Nxt()
            Console.WriteLine("S: '...Well what's your plan?'")
            Nxt()
            Console.WriteLine("R: 'I think I'm just gonna leave.'")
            Nxt()
            Console.WriteLine("R: '...And summon a plague of tumbleweeds to overrun this pathetic town of yours.'")
            Nxt()
            Console.WriteLine("R: 'Yeah, that sounds like fun.'")
            Nxt()
            Console.WriteLine("R: 'It was a real pleasure knowin' you, Sheriff.")
            Nxt()
            Console.WriteLine("The raider throws over the last sheriff's badge, scratched and dented from the stampede.")
            Nxt()
            Console.WriteLine("R: 'Toodles!'")
            Nxt()
            Console.WriteLine("The raider exploits his tumbleweed sorcery to roll his way off the stage, and out of town.")
            Nxt()
            Console.WriteLine("The crowd looks uneasy.")
            Nxt()
            Console.WriteLine("S: '...I'm callin' his bluff, no man has that sort of power.'")
            Nxt()
            Console.WriteLine("Dust slowly rises on the horizon.")
            Nxt()
            Console.WriteLine("A mass of dirt-sodden tumbley weedage approaches at a frightening pace.")
            Nxt()
            Console.WriteLine("Dan: 'What's the plan, Sheriff?'")
            Nxt()
            Console.WriteLine("S: '...'")
            Nxt()

            Console.WriteLine("ENDING 5: WEEDED OUT")
            Nxt()

            Title()

            GoTo BrokePoint

        ElseIf Input = "3" Then

            Console.Clear()

            Console.WriteLine("The Sheriff instinctively unholsters and chucks his gun at the Raider, knocking him out.")
            Nxt()
            Console.WriteLine("Sheriff: 'Oh. OH. WHAT HAVE I DONE.'")
            Nxt()
            Console.WriteLine("The Sheriff drops to his knees.")
            Nxt()
            Console.WriteLine("Dan: 'Good throwin' arm boss, you saved us!'")
            Nxt()
            Console.WriteLine("S: 'OH NO! THIS IS AWFUL!'")
            Nxt()
            Console.WriteLine("D 'Sheriff, what's the issue? He's out cold!'")
            Nxt()
            Console.WriteLine("S: 'I NEVER WANTED TO HURT ANYONE! THIS IS AWFUL!'")
            Nxt()
            Console.WriteLine("D 'But... You've trained so long to be the Sheriff.'")
            Nxt()
            Console.WriteLine("D '...You do know what a Sheriff does, right?'")
            Nxt()
            Console.WriteLine("S: 'They administer the law, they don't hurt people!'")
            Nxt()
            Console.WriteLine("S: 'That throw is reserved for administering justice to those dang racoons, munchin' through my bean crops!'")
            Nxt()
            Console.WriteLine("D '...'")
            Nxt()
            Console.WriteLine("D 'So you don't want to hurt people, but you want to administer justice?'")
            Nxt()
            Console.WriteLine("S: 'That's the dream, pardner.'")
            Nxt()
            Console.WriteLine("D 'Ever consider politics?'")
            Nxt()
            Console.WriteLine("S: 'I'm almost completely illiterate and my knowledge of political topics is limited.'")
            Nxt()
            Console.WriteLine("D '...But you know how to grow beans?'")
            Nxt()
            Console.WriteLine("S: 'Of course, everyone 'round here knows how to grow a mean bean.'")
            Nxt()
            Console.WriteLine("D 'You'll be perfect!'")
            Nxt()

            Console.Clear()
            Console.WriteLine("ENDING 6: MAYOR SHERIFF")
            Nxt()

            Console.WriteLine("Together, Sheriff and Dan ran for political office, and helped poor farmers")
            Console.WriteLine("who were trying to recover thier crops after the Tumbleweed Crisis.")
            Nxt()
            Console.WriteLine("To this day, the town of Sheridan, Wyoming still stands.")
            Nxt()
            Console.WriteLine("And they still grow beans, and have tumbleweeds.")
            Nxt()
            Console.WriteLine("I'd assume.")
            Nxt()
            Console.WriteLine("I don't actually know anything about Sheridan, Wyoming.")
            Nxt()
            Console.WriteLine("The name was just too convienent.")
            Nxt()

            Console.WriteLine("THE END")
            Nxt()

            Title()

        Else

            GoTo BrokePoint
        End If

    End Sub

    Private Sub transitionTick(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)
        Console.WriteLine(transitionText)
        tCount += 1

        If tCount > tEnd - 1 Then
            c += 1
            transitionTimer.Stop()
        End If
    End Sub

    Private Sub drawTick(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)
        Console.WriteLine(drawText)
        dCount += 1

        If dCount > dEnd - 1 Then
            c += 1
            drawTimer.Stop()
        End If
    End Sub

End Module
