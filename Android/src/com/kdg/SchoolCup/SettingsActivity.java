package com.kdg.SchoolCup;

import android.app.Activity;
import android.os.Bundle;

/**
 * Created with IntelliJ IDEA.
 * User: FezzFest
 * Date: 21/02/13
 * Time: 17:51
 * To change this template use File | Settings | File Templates.
 */
public class SettingsActivity extends Activity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        // Set application theme
        String theme = "light";
        if (theme.equals("light")) {
            setTheme(android.R.style.Theme_Holo_Light);
        } else {
            setTheme(android.R.style.Theme_Black);
        }

        super.onCreate(savedInstanceState);

        // Display the fragment as the main content.
        getFragmentManager().beginTransaction().replace(android.R.id.content, new SettingsFragment()).commit();
    }
}
