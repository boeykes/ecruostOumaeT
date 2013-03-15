package com.kdg.SchoolCup;

import android.app.Fragment;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

/**
 * Created with IntelliJ IDEA.
 * User: FezzFest
 * Date: 8/02/13
 * Time: 14:59
 * To change this template use File | SettingsFragment | File Templates.
 */
public class Home extends Fragment {
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        return inflater.inflate(R.layout.home, container, false);
    }
}
