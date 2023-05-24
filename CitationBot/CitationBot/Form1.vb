Public Class formCitationBot

    Private Sub tabEmail_Click(sender As Object, e As EventArgs) Handles tabEmail.Click

    End Sub

    Private Sub txtEmailInTextCitation_TextChanged(sender As Object, e As EventArgs) Handles txtEmailInTextCitation.TextChanged

    End Sub

    Private Sub txtEmailFullCitation_TextChanged(sender As Object, e As EventArgs) Handles txtEmailFullCitation.TextChanged

    End Sub

    Private Sub btnEmailGenerateCitation_Click(sender As Object, e As EventArgs) Handles btnEmailGenerateCitation.Click

        txtEmailInTextCitation.Text = "(" & txtEmailLastName.Text & ")"
        txtEmailFullCitation.Text = $"{txtEmailLastName.Text}, {txtEmailFirstName.Text}. {txtEmailSubject.Text}. {nudEmailYear.Value}. Email."

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub nudEmailYear_ValueChanged(sender As Object, e As EventArgs) Handles nudEmailYear.ValueChanged

    End Sub

    Private Sub txtEmailSubject_TextChanged(sender As Object, e As EventArgs) Handles txtEmailSubject.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtEmailEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmailEmail.TextChanged

    End Sub

    Private Sub txtEmailLastName_TextChanged(sender As Object, e As EventArgs) Handles txtEmailLastName.TextChanged

    End Sub

    Private Sub txtEmailFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtEmailFirstName.TextChanged

    End Sub

    Private Sub tabCitation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabCitation.SelectedIndexChanged

    End Sub

    Private Sub tabVideo_Click(sender As Object, e As EventArgs) Handles tabVideo.Click

    End Sub

    Private Sub txtVideoInTextCitation_TextChanged(sender As Object, e As EventArgs) Handles txtVideoInTextCitation.TextChanged

    End Sub

    Private Sub txtVideoFullCitation_TextChanged(sender As Object, e As EventArgs) Handles txtVideoFullCitation.TextChanged

    End Sub

    Private Sub btnVideoGenerateCitation_Click(sender As Object, e As EventArgs) Handles btnVideoGenerateCitation.Click

        Dim strVideoMonth As String = ""

        If nudVideoMonth.Value = 1 Then
            strVideoMonth = "Jan."
        ElseIf nudVideoMonth.Value = 2 Then
            strVideoMonth = "Feb."
        ElseIf nudVideoMonth.Value = 3 Then
            strVideoMonth = "Mar."
        ElseIf nudVideoMonth.Value = 4 Then
            strVideoMonth = "Apr."
        ElseIf nudVideoMonth.Value = 5 Then
            strVideoMonth = "May"
        ElseIf nudVideoMonth.Value = 6 Then
            strVideoMonth = "Jun."
        ElseIf nudVideoMonth.Value = 7 Then
            strVideoMonth = "Jul."
        ElseIf nudVideoMonth.Value = 8 Then
            strVideoMonth = "Aug."
        ElseIf nudVideoMonth.Value = 9 Then
            strVideoMonth = "Sept."
        ElseIf nudVideoMonth.Value = 10 Then
            strVideoMonth = "Oct."
        ElseIf nudVideoMonth.Value = 11 Then
            strVideoMonth = "Nov."
        ElseIf nudVideoMonth.Value = 12 Then
            strVideoMonth = "Dec."
        End If

        txtVideoInTextCitation.Text = "(" & txtVideoLastName.Text & ")"
        txtVideoFullCitation.Text = $"{txtVideoLastName.Text}, {txtVideoFirstName.Text}. {txtVideoTitle.Text} {txtVideoDescription.Text}. {nudEmailYear.Value}. Web. {nudVideoDay.Value} {strVideoMonth} {nudVideoYear.Value}."

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub txtVideoDescription_TextChanged(sender As Object, e As EventArgs) Handles txtVideoDescription.TextChanged

    End Sub

    Private Sub txtVideoTitle_TextChanged(sender As Object, e As EventArgs) Handles txtVideoTitle.TextChanged

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub nudVideoDay_ValueChanged(sender As Object, e As EventArgs) Handles nudVideoDay.ValueChanged

    End Sub

    Private Sub nudVideoMonth_ValueChanged(sender As Object, e As EventArgs) Handles nudVideoMonth.ValueChanged

    End Sub

    Private Sub nudVideoYear_ValueChanged(sender As Object, e As EventArgs) Handles nudVideoYear.ValueChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtVideoCorperation_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtVideoLastName_TextChanged(sender As Object, e As EventArgs) Handles txtVideoLastName.TextChanged

    End Sub

    Private Sub txtVideoFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtVideoFirstName.TextChanged

    End Sub

    Private Sub tabBook_Click(sender As Object, e As EventArgs) Handles tabBook.Click

    End Sub

    Private Sub txtInTextCitation_TextChanged(sender As Object, e As EventArgs) Handles txtBookInTextCitation.TextChanged

    End Sub

    Private Sub txtFullCitation_TextChanged(sender As Object, e As EventArgs) Handles txtBookFullCitation.TextChanged

    End Sub

    Private Sub btnBookGenerateCitation_Click(sender As Object, e As EventArgs) Handles btnBookGenerateCitation.Click

        Dim strBookVolume As String = ""

        If nudBookEdition.Value < 1 Then
            strBookVolume = ""
        ElseIf nudBookEdition.Value = 1 Then
            strBookVolume = $" {nudBookEdition.Value}st ed. "
        ElseIf nudBookEdition.Value = 2 Then
            strBookVolume = $" {nudBookEdition.Value}nd ed. "
        ElseIf nudBookEdition.Value = 3 Then
            strBookVolume = $" {nudBookEdition.Value}rd ed. "
        ElseIf nudBookEdition.Value > 3 Then
            strBookVolume = $" {nudBookEdition.Value}th ed. "
        End If

        txtBookInTextCitation.Text = $"({txtBookLastName.Text} {txtBookPages.Text})"
        txtBookFullCitation.Text = $"{txtBookLastName.Text}, {txtBookFirstName.Text}. {txtBookTitle.Text}.{strBookVolume}{txtBookCity.Text}: {txtBookPublisher.Text}, {nudBookYear.Value}. Print."

    End Sub

    Private Sub GroupBox8_Enter(sender As Object, e As EventArgs) Handles GroupBox8.Enter

    End Sub

    Private Sub nudBookYear_ValueChanged(sender As Object, e As EventArgs) Handles nudBookYear.ValueChanged

    End Sub

    Private Sub txtBookCity_TextChanged(sender As Object, e As EventArgs) Handles txtBookCity.TextChanged

    End Sub

    Private Sub txtBookPublisher_TextChanged(sender As Object, e As EventArgs) Handles txtBookPublisher.TextChanged

    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub nudBookEdition_ValueChanged(sender As Object, e As EventArgs) Handles nudBookEdition.ValueChanged

    End Sub

    Private Sub txtBookTitle_TextChanged(sender As Object, e As EventArgs) Handles txtBookTitle.TextChanged

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub txtBookLastName_TextChanged(sender As Object, e As EventArgs) Handles txtBookLastName.TextChanged

    End Sub

    Private Sub txtBookFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtBookFirstName.TextChanged

    End Sub

    Private Sub tabWebsite_Click(sender As Object, e As EventArgs) Handles tabWebsite.Click

    End Sub

    Private Sub txtWebsiteInTextCitation_TextChanged(sender As Object, e As EventArgs) Handles txtWebsiteInTextCitation.TextChanged

    End Sub

    Private Sub txtWebsiteFullCitation_TextChanged(sender As Object, e As EventArgs) Handles txtWebsiteFullCitation.TextChanged

    End Sub

    Private Sub btnWebsiteGenerateCitation_Click(sender As Object, e As EventArgs) Handles btnWebsiteGenerateCitation.Click

        Dim strWebsiteMonth As String = ""

        If nudWebsiteMonth.Value = 1 Then
            strWebsiteMonth = "Jan."
        ElseIf nudWebsiteMonth.Value = 2 Then
            strWebsiteMonth = "Feb."
        ElseIf nudWebsiteMonth.Value = 3 Then
            strWebsiteMonth = "Mar."
        ElseIf nudWebsiteMonth.Value = 4 Then
            strWebsiteMonth = "Apr."
        ElseIf nudWebsiteMonth.Value = 5 Then
            strWebsiteMonth = "May"
        ElseIf nudWebsiteMonth.Value = 6 Then
            strWebsiteMonth = "Jun."
        ElseIf nudWebsiteMonth.Value = 7 Then
            strWebsiteMonth = "Jul."
        ElseIf nudWebsiteMonth.Value = 8 Then
            strWebsiteMonth = "Aug."
        ElseIf nudWebsiteMonth.Value = 9 Then
            strWebsiteMonth = "Sept."
        ElseIf nudWebsiteMonth.Value = 10 Then
            strWebsiteMonth = "Oct."
        ElseIf nudWebsiteMonth.Value = 11 Then
            strWebsiteMonth = "Nov."
        ElseIf nudWebsiteMonth.Value = 12 Then
            strWebsiteMonth = "Dec."
        End If

        txtWebsiteInTextCitation.Text = $"({txtWebsiteLastName.Text})"
        txtWebsiteFullCitation.Text = $"{txtWebsiteLastName.Text}, {txtWebsiteFirstName.Text}. {txtWebsitePageTitle.Text}. {txtWebsiteSiteName.Text}. {nudWebsiteYear.Value}. Web. {nudWebsiteDay.Value} {strWebsiteMonth} {nudWebsiteYear.Value}."

    End Sub

    Private Sub GroupBox11_Enter(sender As Object, e As EventArgs) Handles GroupBox11.Enter

    End Sub

    Private Sub nudWebsiteDay_ValueChanged(sender As Object, e As EventArgs) Handles nudWebsiteDay.ValueChanged

    End Sub

    Private Sub nudWebsiteMonth_ValueChanged(sender As Object, e As EventArgs) Handles nudWebsiteMonth.ValueChanged

    End Sub

    Private Sub nudWebsiteYear_ValueChanged(sender As Object, e As EventArgs) Handles nudWebsiteYear.ValueChanged

    End Sub

    Private Sub GroupBox10_Enter(sender As Object, e As EventArgs) Handles GroupBox10.Enter

    End Sub

    Private Sub txtWebsiteSiteName_TextChanged(sender As Object, e As EventArgs) Handles txtWebsiteSiteName.TextChanged

    End Sub

    Private Sub txtWebsitePageTitle_TextChanged(sender As Object, e As EventArgs) Handles txtWebsitePageTitle.TextChanged

    End Sub

    Private Sub GroupBox9_Enter(sender As Object, e As EventArgs) Handles GroupBox9.Enter

    End Sub

    Private Sub txtWebsiteLastName_TextChanged(sender As Object, e As EventArgs) Handles txtWebsiteLastName.TextChanged

    End Sub

    Private Sub txtWebsiteFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtWebsiteFirstName.TextChanged

    End Sub

    Private Sub tabNewspaper_Click(sender As Object, e As EventArgs) Handles tabNewspaper.Click

    End Sub

    Private Sub txtNewspaperInTextCitation_TextChanged(sender As Object, e As EventArgs) Handles txtNewspaperInTextCitation.TextChanged

    End Sub

    Private Sub txtNewspaperFullCitation_TextChanged(sender As Object, e As EventArgs) Handles txtNewspaperFullCitation.TextChanged

    End Sub

    Private Sub btnNewspaperGenerateCitation_Click(sender As Object, e As EventArgs) Handles btnNewspaperGenerateCitation.Click

        txtNewspaperInTextCitation.Text = $"({txtNewspaperLastName.Text})"
        txtNewspaperFullCitation.Text = $"{txtNewspaperLastName.Text}, {txtNewspaperFirstName.Text}. {txtNewspaperArticleTitle.Text}. {txtNewspaperPaperName.Text} {nudNewspaperYear.Value}: {txtNewspaperPagesUsed.Text}. Print."

    End Sub

    Private Sub GroupBox14_Enter(sender As Object, e As EventArgs) Handles GroupBox14.Enter

    End Sub

    Private Sub nudNewspaperYear_ValueChanged(sender As Object, e As EventArgs) Handles nudNewspaperYear.ValueChanged

    End Sub

    Private Sub txtNewspaperPagesUsed_TextChanged(sender As Object, e As EventArgs) Handles txtNewspaperPagesUsed.TextChanged

    End Sub

    Private Sub GroupBox13_Enter(sender As Object, e As EventArgs) Handles GroupBox13.Enter

    End Sub

    Private Sub txtNewspaperArticleTitle_TextChanged(sender As Object, e As EventArgs) Handles txtNewspaperArticleTitle.TextChanged

    End Sub

    Private Sub txtNewspaperPaperName_TextChanged(sender As Object, e As EventArgs) Handles txtNewspaperPaperName.TextChanged

    End Sub

    Private Sub GroupBox12_Enter(sender As Object, e As EventArgs) Handles GroupBox12.Enter

    End Sub

    Private Sub txtNewspaperLastName_TextChanged(sender As Object, e As EventArgs) Handles txtNewspaperLastName.TextChanged

    End Sub

    Private Sub txtNewspaperFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtNewspaperFirstName.TextChanged

    End Sub

    Private Sub tabReport_Click(sender As Object, e As EventArgs) Handles tabReport.Click

    End Sub

    Private Sub txtReportInTextCitation_TextChanged(sender As Object, e As EventArgs) Handles txtReportInTextCitation.TextChanged

    End Sub

    Private Sub txtReportFullCitation_TextChanged(sender As Object, e As EventArgs) Handles txtReportFullCitation.TextChanged

    End Sub

    Private Sub btnReportGenerateCitation_Click(sender As Object, e As EventArgs) Handles btnReportGenerateCitation.Click

        txtReportInTextCitation.Text = $"({txtReportLastName.Text})"
        txtReportFullCitation.Text = $"{txtReportLastName.Text}, {txtReportFirstName.Text}. {txtReportTitle.Text}. {txtReportCity.Text}: {txtReportPublisher.Text}, {nudReportYear.Value}. Print. {txtReportSeriesTitle.Text}."

    End Sub

    Private Sub GroupBox17_Enter(sender As Object, e As EventArgs) Handles GroupBox17.Enter

    End Sub

    Private Sub txtReportSeriesTitle_TextChanged(sender As Object, e As EventArgs) Handles txtReportSeriesTitle.TextChanged

    End Sub

    Private Sub txtReportTitle_TextChanged(sender As Object, e As EventArgs) Handles txtReportTitle.TextChanged

    End Sub

    Private Sub GroupBox16_Enter(sender As Object, e As EventArgs) Handles GroupBox16.Enter

    End Sub

    Private Sub nudReportYear_ValueChanged(sender As Object, e As EventArgs) Handles nudReportYear.ValueChanged

    End Sub

    Private Sub txtReportCity_TextChanged(sender As Object, e As EventArgs) Handles txtReportCity.TextChanged

    End Sub

    Private Sub txtReportPublisher_TextChanged(sender As Object, e As EventArgs) Handles txtReportPublisher.TextChanged

    End Sub

    Private Sub GroupBox15_Enter(sender As Object, e As EventArgs) Handles GroupBox15.Enter

    End Sub

    Private Sub txtReportCorporation_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtReportLastName_TextChanged(sender As Object, e As EventArgs) Handles txtReportLastName.TextChanged

    End Sub

    Private Sub txtReportFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtReportFirstName.TextChanged

    End Sub

End Class
