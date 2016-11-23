Imports System.Net.Mail
Imports System.Data.OleDb
Public Class PracticeQuiz
    Dim completed As Boolean = False
    Public Shared QuizPoints As Integer = 0
    Private conn As OleDbConnection
    Private dapt As OleDbDataAdapter
    Dim emailaddress As String
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public Structure ExamQuestions
        Dim question As String
        Dim answer1 As String
        Dim answer2 As String
        Dim answer3 As String
        Dim correct As String
        Dim category As String
    End Structure
    Dim TestQuestions(100) As ExamQuestions
    Private Sub MyConnection()
        conn = New OleDbConnection("Provider =Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Logins.accdb")
        conn.Open()
    End Sub
    Private Sub PracticeQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If completed = True Then
            Dim Mail As New MailMessage
            Mail.Subject = "Practice Quiz Results"
            Mail.To.Add("boull002@stpaulscc.co.uk")
            Mail.From = New MailAddress("l2drivingtheory@gmail.com")
            Mail.Body = "On this test you scored " & QuizPoints

            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("l2drivingtheory", "drivingtheory")
            SMTP.Port = "587"
            SMTP.Send(Mail)
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        TestQuestions(51).question = "Why are vehicles fitted with rear fog lights?"
        TestQuestions(51).answer1 = "To make them more visible at high speed"
        TestQuestions(51).answer2 = "To show when they've broken down in a dangerous position"
        TestQuestions(51).answer3 = "To warn drivers following closely to drop back"
        TestQuestions(51).correct = "To make them more visible in thick fog"
        TestQuestions(51).category = "Vehicle Handling"
        TestQuestions(52).question = "What do traffic-calming measures do?"
        TestQuestions(52).answer1 = "Stop road rage"
        TestQuestions(52).answer2 = "Make overtaking easier"
        TestQuestions(52).answer3 = "Make parking easier"
        TestQuestions(52).correct = "Slow traffic down"
        TestQuestions(52).category = "Vehicle Handling"
        TestQuestions(53).question = "What should you do if you park on the road when it's foggy?"
        TestQuestions(53).answer1 = "Leave dipped headlights and fog lights switched on"
        TestQuestions(53).answer2 = "Leave dipped headlights switched on"
        TestQuestions(53).answer3 = "Leave main-beam headlights switched on"
        TestQuestions(53).correct = "Leave sidelights switched on"
        TestQuestions(53).category = "Vehicle Handling"
        TestQuestions(54).question = "Why could it be dangerous to keep the clutch down, or select neutral, for long periods of time when you're driving?"
        TestQuestions(54).answer1 = "Fuel spillage will occur"
        TestQuestions(54).answer2 = "Engine damage may be caused"
        TestQuestions(54).answer3 = "It will wear the tyres out more quickly"
        TestQuestions(54).correct = "You'll have less steering and braking control"
        TestQuestions(54).category = "Vehicle Handling"
        TestQuestions(55).question = "You're driving down a steep hill. Why could it be dangerous to keep the clutch down or roll in neutral for too long?"
        TestQuestions(55).answer1 = "Fuel consumption will be higher"
        TestQuestions(55).answer2 = "It will damage the engine"
        TestQuestions(55).answer3 = "It will wear the tyres out more quickly"
        TestQuestions(55).correct = "Your vehicle will pick up speed"
        TestQuestions(55).category = "Vehicle Handling"
    End Sub

    Private Sub StartQuizBtn_Click(sender As Object, e As EventArgs) Handles StartQuizBtn.Click
        Me.Controls.Remove(CheckBox1)
        Me.Controls.Remove(CheckBox2)
        Me.Controls.Remove(CheckBox3)
        Me.Controls.Remove(CheckBox4)
        Me.Controls.Remove(CheckBox5)
        Me.Controls.Remove(CheckBox6)
        Me.Controls.Remove(CheckBox7)
        Me.Controls.Remove(CheckBox8)
        Me.Controls.Remove(CheckBox9)
        Me.Controls.Remove(StartQuizBtn)
        Me.Controls.Remove(CheckBox10)
        Me.Controls.Remove(CheckBox11)
        Me.Controls.Remove(CheckBox12)
        Me.Controls.Remove(CheckBox13)
        Me.Controls.Remove(CheckBox14)
        Me.Controls.Remove(Logo)
        Me.Controls.Remove(QuizIMG)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TestQuestions(0).question = "When you are driving whent tired, what should you do?"
        TestQuestions(0).answer1 = "Take a nap at the wheel"
        TestQuestions(0).answer2 = "Pull over onto the hard shoulder"
        TestQuestions(0).answer3 = "Open a window"
        TestQuestions(0).correct = "Stop at the nearest service station and rest"
        TestQuestions(0).category = "Alertness"
        TestQuestions(1).question = "Which of the following should you use before stopping?"
        TestQuestions(1).answer1 = "Sound the horn"
        TestQuestions(1).answer2 = "Select a higher gear"
        TestQuestions(1).answer3 = "Flash the headlights"
        TestQuestions(1).correct = "Use the mirrors"
        TestQuestions(1).category = "Alertness"
        TestQuestions(2).question = "What should you do when moving off from behind a parked car?"
        TestQuestions(2).answer1 = "Give a signal after moving off"
        TestQuestions(2).answer2 = "Look around after moving off"
        TestQuestions(2).answer3 = "Use the exterior mirrors only"
        TestQuestions(2).correct = "Check both interior and exterior mirrors"
        TestQuestions(2).category = "Alertness"
        TestQuestions(3).question = "What should you do when approaching traffic lights that have been green for some time"
        TestQuestions(3).answer1 = "Accelerate hard"
        TestQuestions(3).answer2 = "Maintain your speed"
        TestQuestions(3).answer3 = "Brake hard"
        TestQuestions(3).correct = "Be ready to stop"
        TestQuestions(3).category = "Alertness"
        TestQuestions(4).question = "You're travelling along this narrow country road. How should you pass the cyclist?"
        TestQuestions(4).answer1 = "Sound your horn as you pass"
        TestQuestions(4).answer2 = "Keep close to them as you pass"
        TestQuestions(4).answer3 = "Change down one gear before you pass"
        TestQuestions(4).correct = "Give them plenty of room as you pass"
        TestQuestions(4).category = "Alertness"
        TestQuestions(5).question = "You're turning right onto a dual carriageway. What should you do before emerging?"
        TestQuestions(5).answer1 = "Stop, apply the handbrake and select a low gear"
        TestQuestions(5).answer2 = "Position your vehicle well to the left of the side road"
        TestQuestions(5).answer3 = "Make sure you leave enough room for a vehicle behind"
        TestQuestions(5).correct = "Check that the central reservation is wide enough for your vehicle"
        TestQuestions(5).category = "Alertness"
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        TestQuestions(6).question = "You're being followed by an ambulance showing flashing blue lights. What should you do?"
        TestQuestions(6).answer1 = "Accelerate hard to get away from it"
        TestQuestions(6).answer2 = "Maintain your speed and course"
        TestQuestions(6).answer3 = "Brake harshly and stop well out into the road"
        TestQuestions(6).correct = "Pull over as soon as it's safe to do so"
        TestQuestions(6).category = "Attitude"
        TestQuestions(7).question = "At a puffin crossing, which colour follows the green signal?"
        TestQuestions(7).answer1 = "Steady red"
        TestQuestions(7).answer2 = "Flashing amber"
        TestQuestions(7).answer3 = "Flashing green"
        TestQuestions(7).correct = "Steady amber"
        TestQuestions(7).category = "Attitude"
        TestQuestions(8).question = "You're in a one-way street and want to turn right. There are two lanes. Where should you position your vehicle"
        TestQuestions(8).answer1 = "In the left-hand lane"
        TestQuestions(8).answer2 = "In either lane, depending on the traffic"
        TestQuestions(8).answer3 = "Just left of the centre lane"
        TestQuestions(8).correct = "In the right-hand lane"
        TestQuestions(8).category = "Attitude"
        TestQuestions(9).question = "You're driving a slow-moving vehicle on a narrow, winding road. What should you do?"
        TestQuestions(9).answer1 = "Keep well out to stop vehicles overtaking dangerously"
        TestQuestions(9).answer2 = "Wave following vehicles past you if you think they can overtake quickly"
        TestQuestions(9).answer3 = "Give a left signal when it's safe for vehicles to overtake you"
        TestQuestions(9).correct = "Pull in when you can, to let following vehicles overtake"
        TestQuestions(9).category = "Attitude"
        TestQuestions(10).question = "When should you flash your headlights at other road users?"
        TestQuestions(10).answer1 = "When showing that you're giving way"
        TestQuestions(10).answer2 = "When showing that you're about to turn"
        TestQuestions(10).answer3 = "When telling them that you have right of way"
        TestQuestions(10).correct = "When letting them know you're there"
        TestQuestions(10).category = "Attitude"
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        TestQuestions(11).question = "Your vehicle is insured third-party only. What does this cover?"
        TestQuestions(11).answer1 = "Damage to your vehicle"
        TestQuestions(11).answer2 = "Injury to yourself"
        TestQuestions(11).answer3 = "All damage and injury"
        TestQuestions(11).correct = "Damage to other vehicles"
        TestQuestions(11).category = "Documents"
        TestQuestions(12).question = "What must a newly qualified driver do?"
        TestQuestions(12).answer1 = "Display green L plates"
        TestQuestions(12).answer2 = "Keep under 40mph for 12 months"
        TestQuestions(12).answer3 = "Be accompanied on a motorway"
        TestQuestions(12).correct = "Have valid motor insurance"
        TestQuestions(12).category = "Documents"
        TestQuestions(13).question = "A new car will need its first MOT test when it's how old?"
        TestQuestions(13).answer1 = "One year"
        TestQuestions(13).answer2 = "Five years"
        TestQuestions(13).answer3 = "Seven years"
        TestQuestions(13).correct = "Three years"
        TestQuestions(13).category = "Documents"
        TestQuestions(14).question = "For how long is an MOT certificate normally valid?"
        TestQuestions(14).answer1 = "10,000 miles"
        TestQuestions(14).answer2 = "Three years after the date it was issues"
        TestQuestions(14).answer3 = "30,000 miles"
        TestQuestions(14).correct = "One year after the date it was issued"
        TestQuestions(14).category = "Documents"
        TestQuestions(15).question = "What must you make sure of before you drive someone else's vehicle?"
        TestQuestions(15).answer1 = "That the insurance documents are in the vehicle"
        TestQuestions(15).answer2 = "That the vehicle has third-party insurance cover"
        TestQuestions(15).answer3 = "That your own vehicle has insurance cover"
        TestQuestions(15).correct = "That the vehicle is insured for your use"
        TestQuestions(15).category = "Documents"
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        TestQuestions(16).question = "During periods of illness, your ability to drive may be impaired. What must you do?"
        TestQuestions(16).answer1 = "See a doctor each time before you drive"
        TestQuestions(16).answer2 = "Take smaller doses of medicine"
        TestQuestions(16).answer3 = "Take all your medicines with you when you drive"
        TestQuestions(16).correct = "Make sure your medically fit to drive"
        TestQuestions(16).category = "Hazard Awareness"
        TestQuestions(17).question = "You're planning a long journey. Do you need to plan rest stops?"
        TestQuestions(17).answer1 = "Yes, you should plan to stop every half an hour"
        TestQuestions(17).answer2 = "No, you'll be less tired if you get there as soon as possible"
        TestQuestions(17).answer3 = "No, only fuel stops will be needed"
        TestQuestions(17).correct = "Yes, regular stops help concentration"
        TestQuestions(17).category = "Hazard Awareness"
        TestQuestions(18).question = "A driver pulls out of a side road in front of you, causing you to brake hard. What should you do?"
        TestQuestions(18).answer1 = "Flash your lights to show your annoyance"
        TestQuestions(18).answer2 = "Overtake as soon as possible"
        TestQuestions(18).answer3 = "Sound your horn to show your annoyance"
        TestQuestions(18).correct = "Ignore the error and stay calm"
        TestQuestions(18).category = "Hazard Awareness"
        TestQuestions(19).question = "You find that your eyesight has become very poor and your optician cannot help you. By law, who should you tell?"
        TestQuestions(19).answer1 = "Your own doctor"
        TestQuestions(19).answer2 = "The local police"
        TestQuestions(19).answer3 = "Another optician"
        TestQuestions(19).correct = "The driver licensing authority"
        TestQuestions(19).category = "Hazard Awareness"
        TestQuestions(20).question = "You're about to drive home. You can't find the glasses you need to wear. What should you do?"
        TestQuestions(20).answer1 = "Drive home slowly, keeping to quiet roads"
        TestQuestions(20).answer2 = "Borrow a friend's glasses and use those"
        TestQuestions(20).answer3 = "Drive home at night, so that the lights will help you"
        TestQuestions(20).correct = "Find a way of getting home without driving"
        TestQuestions(20).category = "Hazard Awareness"
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        TestQuestions(21).question = "After a collision, someone is unconscious in their vehicle. When should you call the emergency services?"
        TestQuestions(21).answer1 = "Only as a last resort"
        TestQuestions(21).answer2 = "After you've woken them up"
        TestQuestions(21).answer3 = "After checking for broken bones"
        TestQuestions(21).correct = "As soon as possible"
        TestQuestions(21).category = "Incidents"
        TestQuestions(22).question = "You lose control of your car and damage a garden wall. No-one is around. What must you do?"
        TestQuestions(22).answer1 = "Go back to the house and tell the owner the next day"
        TestQuestions(22).answer2 = "Report the incident to your insurance company as soon as you get home"
        TestQuestions(22).answer3 = "Find someone in the area to tell them about it immediatley"
        TestQuestions(22).correct = "Report the incident to the police within the next 24hrs"
        TestQuestions(22).category = "Incidents"
        TestQuestions(23).question = "On a motorway, when should the hard shoulder be used?"
        TestQuestions(23).answer1 = "When answering a mobile phone"
        TestQuestions(23).answer2 = "When taking a short rest"
        TestQuestions(23).answer3 = "When checking a road map"
        TestQuestions(23).correct = "When an emergency arises"
        TestQuestions(23).category = "Incidents"
        TestQuestions(24).question = "You're in a collision with another moving vehicle. Someone is injured and your vehicle is damaged. What information should you find out?"
        TestQuestions(24).answer1 = "Whether the other driver is licensed to drive"
        TestQuestions(24).answer2 = "The destination of the other driver"
        TestQuestions(24).answer3 = "The occupation of the other driver"
        TestQuestions(24).correct = "The other driver's name, address and telephone number"
        TestQuestions(24).category = "Incidents"
        TestQuestions(25).question = "You're involved in a collision. Afterwards, which document may the police ask you to produce?"
        TestQuestions(25).answer1 = "Vehicle registration document"
        TestQuestions(25).answer2 = "Theory test certificate"
        TestQuestions(25).answer3 = "Vehicle service record"
        TestQuestions(25).correct = "Driving licence"
        TestQuestions(25).category = "Incidents"
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        TestQuestions(26).question = "You're using a smart motorway. What happens when it's operating?"
        TestQuestions(26).answer1 = "Speed limits above lanes are advisory"
        TestQuestions(26).answer2 = "The national speed limit will apply"
        TestQuestions(26).answer3 = "The speed limit is always 30mph"
        TestQuestions(26).correct = "You must obey the speed limits shown"
        TestQuestions(26).category = "Motorway Driving"
        TestQuestions(27).question = "Which vehicles should use the left-hand lane on a three-lane motoway?"
        TestQuestions(27).answer1 = "Large vehicles only"
        TestQuestions(27).answer2 = "Emergency vehicles only"
        TestQuestions(27).answer3 = "Slow vehicles only"
        TestQuestions(27).correct = "Any vehicle"
        TestQuestions(27).category = "Motorway Driving"
        TestQuestions(28).question = "What basic rule applies when you're using a motorway?"
        TestQuestions(28).answer1 = "Use the lane that has the least traffic"
        TestQuestions(28).answer2 = "Overtake on the side that's clearest"
        TestQuestions(28).answer3 = "Try to keep above 50mph to ease congestion"
        TestQuestions(28).correct = "Keep to the left-hand lane unless overtaking"
        TestQuestions(28).category = "Motorway Driving"
        TestQuestions(29).question = "You're travelling in the left-hand lane of a three-lane motorway. How should you react to traffic joining from a slip road?"
        TestQuestions(29).answer1 = "Race the other vehicles"
        TestQuestions(29).answer2 = "Maintain a steady speed"
        TestQuestions(29).answer3 = "Switch on your hazard warning lights"
        TestQuestions(29).correct = "Move to another lane"
        TestQuestions(29).category = "Motorway Driving"
        TestQuestions(30).question = "What's the national speed limit on motorways for cars and motorcycles?"
        TestQuestions(30).answer1 = "30mph"
        TestQuestions(30).answer2 = "50pmh"
        TestQuestions(30).answer3 = "60mph"
        TestQuestions(30).correct = "70mph"
        TestQuestions(30).category = "Motorway Driving"
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        TestQuestions(31).question = "You're waiting to emerge left from a minor road. A large vehicle is approaching from the right. You have time to turn, but you should wait. Why?"
        TestQuestions(31).answer1 = "The large vehicle can turn suddenly"
        TestQuestions(31).answer2 = "The large vehicle is difficult to steer in a straight line"
        TestQuestions(31).answer3 = "The large vehicle can easily hide vehicles from the left"
        TestQuestions(31).correct = "The large vehicle can easily hide an overtaking vehicle"
        TestQuestions(31).category = "Other Types of Vehicle"
        TestQuestions(32).question = "It's very windy. You're behind a motorcyclist who's overtaking a high-sided vehicle. What should you do?"
        TestQuestions(32).answer1 = "Overtake the motorcyclist immediatley"
        TestQuestions(32).answer2 = "Stay level with the motorcyclist"
        TestQuestions(32).answer3 = "Keep close to the motorcyclist"
        TestQuestions(32).correct = "Keep well back"
        TestQuestions(32).category = "Other Types of Vehicle"
        TestQuestions(33).question = "You're driving in heavy traffic on a wet road. Spray makes it difficult to be seen. What lights should you use?"
        TestQuestions(33).answer1 = "Full-beam headlights"
        TestQuestions(33).answer2 = "Sidelights only"
        TestQuestions(33).answer3 = "Rear fog lights if visibility is more than 100 meters (328 feet)"
        TestQuestions(33).correct = "Dipped headlights"
        TestQuestions(33).category = "Other Types of Vehicle"
        TestQuestions(34).question = "You're following a lorry on a wet road. What should you do when spray makes it difficult to see the road ahead?"
        TestQuestions(34).answer1 = "Put your headlights on full beam"
        TestQuestions(34).answer2 = "Keep close to the lorry, away from the spray"
        TestQuestions(34).answer3 = "Speed up and overtake quickly"
        TestQuestions(34).correct = "Drop back until you can see better"
        TestQuestions(34).category = "Other Types of Vehicle"
        TestQuestions(35).question = "You're travelling behind a bus that pulls up at a bus stop. What should you do?"
        TestQuestions(35).answer1 = "Accelerate past the bus"
        TestQuestions(35).answer2 = "Sound your horn"
        TestQuestions(35).answer3 = "Pull in closely behind the bus"
        TestQuestions(35).correct = "Watch carefully for pedestrians"
        TestQuestions(35).category = "Other Types of Vehicle"
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        TestQuestions(36).question = "On which occasion may you enter a box junction?"
        TestQuestions(36).answer1 = "When there are fewer than two vehicles ahead"
        TestQuestions(36).answer2 = "When signalled by another road user"
        TestQuestions(36).answer3 = "When traffic signs direct you"
        TestQuestions(36).correct = "When your exit road is clear"
        TestQuestions(36).category = "Rules of the Road"
        TestQuestions(37).question = "What's the national speed limit on a single carriageway road for cars and motorcycles?"
        TestQuestions(37).answer1 = "30mph"
        TestQuestions(37).answer2 = "50mph"
        TestQuestions(37).answer3 = "70mph"
        TestQuestions(37).correct = "60mph"
        TestQuestions(37).category = "Rules of the Road"
        TestQuestions(38).question = "You're waiting at a level crossing. A train passes but the lights keep flashing. What must you do?"
        TestQuestions(38).answer1 = "Phone the signal operator"
        TestQuestions(38).answer2 = "Edge over the stop line and look for trains"
        TestQuestions(38).answer3 = "Park and investigate"
        TestQuestions(38).correct = "Carry on waiting"
        TestQuestions(38).category = "Rules of the Road"
        TestQuestions(39).question = "You're on a road that's only wide enough for one vehicle. A car is coming towards you. What should you do?"
        TestQuestions(39).answer1 = "Pull into a passing place on your right"
        TestQuestions(39).answer2 = "Force the other driver to reverse"
        TestQuestions(39).answer3 = "Pull into a passing place if your vehicle is wider"
        TestQuestions(39).correct = "Pull into a passing place on your left"
        TestQuestions(39).category = "Rules of the Road"
        TestQuestions(40).question = "You're on a two-lane dual carriageway. Why would you use the right hand lane?"
        TestQuestions(40).answer1 = "For normal progress"
        TestQuestions(40).answer2 = "When staying at the minimum allowed speed"
        TestQuestions(40).answer3 = "To keep driving at a constant high speed"
        TestQuestions(40).correct = "To overtake slower traffic"
        TestQuestions(40).category = "Rules of the Road"
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        TestQuestions(41).question = "You're leaving your vehicle parked on a road and unattended. When may you leave the engine running?"
        TestQuestions(41).answer1 = "If you'll be parked for less than five minutes"
        TestQuestions(41).answer2 = "If the battery keeps going flat"
        TestQuestions(41).answer3 = "When parked in a 20mph zone"
        TestQuestions(41).correct = "Never if you're away from the vehicle"
        TestQuestions(41).category = "Safety and your Vehicle"
        TestQuestions(42).question = "When you use the brakes, your vehicle pulls to one side. What should you do?"
        TestQuestions(42).answer1 = "Increase the pressure in your tyres"
        TestQuestions(42).answer2 = "Change gear and pump the brake pedal"
        TestQuestions(42).answer3 = "Use your parking brake at the same time"
        TestQuestions(42).correct = "Have the brakes checked as soon as possible"
        TestQuestions(42).category = "Safety and your Vehicle"
        TestQuestions(43).question = "What should you do when leaving your vehicle parked and unattended?"
        TestQuestions(43).answer1 = "Park near a busy junction"
        TestQuestions(43).answer2 = "Park in a housing estate"
        TestQuestions(43).answer3 = "Leave the left indicator on"
        TestQuestions(43).correct = "Lock it and remove the key"
        TestQuestions(43).category = "Safety and your Vehicle"
        TestQuestions(44).question = "You're carrying a five-year-old child in the back seat of your car. They're under 1.35 meters tall. A correct child restraint isn't avaliable. How should you seat them?"
        TestQuestions(44).answer1 = "Behind the passenger seat"
        TestQuestions(44).answer2 = "Sharing a belt with an adult"
        TestQuestions(44).answer3 = "Between two other children"
        TestQuestions(44).correct = "Using an adult seat belt"
        TestQuestions(44).category = "Safety and your Vehicle"
        TestQuestions(45).question = "What can cause excessive or uneven tyre wear?"
        TestQuestions(45).answer1 = "Faults in the gearbox"
        TestQuestions(45).answer2 = "Faults in the engine"
        TestQuestions(45).answer3 = "Faults in the exhaust system"
        TestQuestions(45).correct = "Faults in the suspension"
        TestQuestions(45).category = "Safety and your Vehicle"
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        TestQuestions(46).question = "You're driving in a built-up area that has traffic-calming measures. What should you do when you approach a road hump?"
        TestQuestions(46).answer1 = "Move across to the left-hand side of the road"
        TestQuestions(46).answer2 = "Wait for any pedestrians to cross"
        TestQuestions(46).answer3 = "Stop and check both pavements"
        TestQuestions(46).correct = "Check your mirror and slow down"
        TestQuestions(46).category = "Safety Margins"
        TestQuestions(47).question = "In good conditions, what's the typical stopping distance at 70mph?"
        TestQuestions(47).answer1 = "53 metres (175 feet)"
        TestQuestions(47).answer2 = "60 metres (197 feet)"
        TestQuestions(47).answer3 = "73 metres (240 feet)"
        TestQuestions(47).correct = "96 metres (315 feet)"
        TestQuestions(47).category = "Safety Margins"
        TestQuestions(48).question = "How can you use your vehicle's engine as a brake?"
        TestQuestions(48).answer1 = "By selecting reverse gear"
        TestQuestions(48).answer2 = "By changing to a higher gear"
        TestQuestions(48).answer3 = "By selecting neutral gear"
        TestQuestions(48).correct = "By selecting a lower gear"
        TestQuestions(48).category = "Safety Margins"
        TestQuestions(49).question = "You're using contraflow system. What should you do?"
        TestQuestions(49).answer1 = "Switch lanes at any time to make progress"
        TestQuestions(49).answer2 = "Increase your speed to pass through quickly"
        TestQuestions(49).answer3 = "Follow other motorists closely to avoid long queues"
        TestQuestions(49).correct = "Choose an appropriate lane in good time"
        TestQuestions(49).category = "Safety Margins"
        TestQuestions(50).question = "What should you do when you're driving in snowy conditions?"
        TestQuestions(50).answer1 = "Brake firmly and quickly"
        TestQuestions(50).answer2 = "Be ready to steer sharply"
        TestQuestions(50).answer3 = "Use sidelights only"
        TestQuestions(50).correct = "Brake gently in plenty of time"
        TestQuestions(50).category = "Safety Margins"
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        TestQuestions(56).question = "You're towing a small trailer on a busy three-lane motorway. What must you do if all the lanes are open?"
        TestQuestions(56).answer1 = "Not exceed 50mph"
        TestQuestions(56).answer2 = "Not overtake"
        TestQuestions(56).answer3 = "Have a stabiliser fitted"
        TestQuestions(56).correct = "Use only the left-hand and centre lanes"
        TestQuestions(56).category = "Vehicle Loading"
        TestQuestions(57).question = "How will a heavy load on your roof rack affect your vehicle's handling?"
        TestQuestions(57).answer1 = "It will improve the road holding"
        TestQuestions(57).answer2 = "It will reduce the stopping distance"
        TestQuestions(57).answer3 = "It will making steering lighter"
        TestQuestions(57).correct = "It will reduce stability"
        TestQuestions(57).category = "Vehicle Loading"
        TestQuestions(58).question = "Are passengers allowed to ride in a caravan that's being towed?"
        TestQuestions(58).answer1 = "Yes, if they're over 14"
        TestQuestions(58).answer2 = "Only if all the seats in the towing vehicle are full"
        TestQuestions(58).answer3 = "Only if a stabiliser is fitted"
        TestQuestions(58).correct = "No, not at any time"
        TestQuestions(58).category = "Vehicle Handling"
        TestQuestions(59).question = "What should you do if a trailer starts to swing from side to side while you're towing it?"
        TestQuestions(59).answer1 = "Let go of the steering wheel and let it correct itself"
        TestQuestions(59).answer2 = "Brake hard and hold the pedal down"
        TestQuestions(59).answer3 = "Accelerate until it stabilises"
        TestQuestions(59).correct = "Ease off the accelerator to reduce your speed"
        TestQuestions(59).category = "Vehicle Loading"
        TestQuestions(60).question = "Who's responsible for making sure that a vehicle isn't overloaded?"
        TestQuestions(60).answer1 = "The owner of the items being carried"
        TestQuestions(60).answer2 = "The person who loaded the vehicle"
        TestQuestions(60).answer3 = "The licensing authority"
        TestQuestions(60).correct = "The driver of the vehicle"
        TestQuestions(60).category = "Vehicle Loading"
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        TestQuestions(61).question = "You're unsure what a slow-moving motorcyclist ahead of you is going to do. What should you do?"
        TestQuestions(61).answer1 = "Pass on the left"
        TestQuestions(61).answer2 = "Pass on the right"
        TestQuestions(61).answer3 = "Move closer"
        TestQuestions(61).correct = "Stay behind"
        TestQuestions(61).category = "Vulnerable Road Users"
        TestQuestions(62).question = "You're about to reverse into a side road. A pedestrian is waiting to cross behind you. What should you do?"
        TestQuestions(62).answer1 = "Wave to the pedestrian to stop"
        TestQuestions(62).answer2 = "Sound your horn to warn the pedestrian"
        TestQuestions(62).answer3 = "Reverse before the pedestrian starts to cross"
        TestQuestions(62).correct = "Give way to the pedestrian"
        TestQuestions(62).category = "Vulnerable Road Users"
        TestQuestions(63).question = "You notice road users in front. What should you do first?"
        TestQuestions(63).answer1 = "Pull out to the middle of the road"
        TestQuestions(63).answer2 = "Accelerate around them"
        TestQuestions(63).answer3 = "Signal right"
        TestQuestions(63).correct = "Slow down and be ready to stop"
        TestQuestions(63).category = "Vulnerable Road Users"
        TestQuestions(64).question = "What should you do when you see two elderly pedestrians about to cross the road ahead?"
        TestQuestions(64).answer1 = "Expect them to wait for you to pass"
        TestQuestions(64).answer2 = "Speed up to get past them quickly"
        TestQuestions(64).answer3 = "Stop and wave them across the road"
        TestQuestions(64).correct = "Be careful; they misjudge your speed"
        TestQuestions(64).category = "Vulnerable Road Users"
        TestQuestions(65).question = "Who's especially in danger of not being seen as you reverse your car?"
        TestQuestions(65).answer1 = "Motorcyclists"
        TestQuestions(65).answer2 = "Car drivers"
        TestQuestions(65).answer3 = "Cyclists"
        TestQuestions(65).correct = "Children"
        TestQuestions(65).category = "Vulnerable Road Users"
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged

    End Sub
End Class