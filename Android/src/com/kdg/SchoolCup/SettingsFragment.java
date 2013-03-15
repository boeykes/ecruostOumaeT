package com.kdg.SchoolCup;

import android.os.Bundle;
import android.preference.PreferenceFragment;

/**
 * Created with IntelliJ IDEA.
 * User: FezzFest
 * Date: 20/02/13
 * Time: 18:14
 * To change this template use File | SettingsFragment | File Templates.
 */
public class SettingsFragment extends PreferenceFragment {
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        // Load the preferences from an XML resource
        addPreferencesFromResource(R.xml.preferences);
    }
}
