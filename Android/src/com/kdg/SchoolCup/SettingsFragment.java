package com.kdg.SchoolCup;

import android.content.SharedPreferences;
import android.os.Bundle;
import android.preference.PreferenceFragment;

/**
 * Created with IntelliJ IDEA.
 * User: FezzFest
 * Date: 20/02/13
 * Time: 18:14
 * To change this template use File | SettingsFragment | File Templates.
 */
public class SettingsFragment extends PreferenceFragment implements SharedPreferences.OnSharedPreferenceChangeListener {
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        // Load the preferences from an XML resource
        addPreferencesFromResource(R.xml.preferences);
    }

    @Override
    public void onSharedPreferenceChanged(SharedPreferences sharedPreferences, String key) {
        String theme = sharedPreferences.getString("pref_theme", "");
        if (key.equals("pref_theme")) {
            // Set theme
            if (theme.equals("light")) {
                getActivity().setTheme(android.R.style.Theme_Holo_Light);
                MainActivity.activity.setTheme(android.R.style.Theme_Holo_Light);
            } else {
                getActivity().setTheme(android.R.style.Theme_Holo);
                MainActivity.activity.setTheme(android.R.style.Theme_Holo_Light);
            }
            // Apply theme
            getActivity().recreate();
            MainActivity.activity.recreate();

            //Preference connectionPref = SharedPreferences.findPreference(key);
            // Set summary to be the user-description for the selected value
            //connectionPref.setSummary(sharedPreferences.getString(key, ""));
        }
    }

    @Override
    public void onResume() {
        super.onResume();
        // Set up a listener whenever a key changes
        getPreferenceScreen().getSharedPreferences().registerOnSharedPreferenceChangeListener(this);
    }

    @Override
    public void onPause() {
        super.onPause();
        // Unregister the listener whenever a key changes
        getPreferenceScreen().getSharedPreferences().unregisterOnSharedPreferenceChangeListener(this);
    }
}
