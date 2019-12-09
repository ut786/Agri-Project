package com.sparkerz.pakfarmers.fragments.buyfragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.sparkerz.pakfarmers.R;
import com.sparkerz.pakfarmers.fragments.buyfragment.BuyAdFragment.OnListFragmentInteractionListener;
import com.sparkerz.pakfarmers.fragments.buyfragment.dummy.DummyContent.DummyItem;

import java.util.List;

import androidx.recyclerview.widget.RecyclerView;

/**
 * {@link RecyclerView.Adapter} that can display a {@link DummyItem} and makes a call to the
 * specified {@link OnListFragmentInteractionListener}.
 * TODO: Replace the implementation with code for your data type.
 */
public class MyBuyAdRecyclerViewAdapter extends RecyclerView.Adapter<MyBuyAdRecyclerViewAdapter.ViewHolder> {

    private final List<DummyItem> mValues;
    private final OnListFragmentInteractionListener mListener;

    public MyBuyAdRecyclerViewAdapter(List<DummyItem> items, OnListFragmentInteractionListener listener) {
        mValues = items;
        mListener = listener;
    }

    @Override
    public ViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.fragment_buyad, parent, false);
        return new ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(final ViewHolder holder, int position) {
        holder.mItem = mValues.get(position);
        holder.txtTitle.setText(mValues.get(position).content);
        holder.txtPrice.setText("1000");

        holder.mView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (null != mListener) {
                    // Notify the active callbacks interface (the activity, if the
                    // fragment is attached to one) that an item has been selected.
                    mListener.onListFragmentInteraction(holder.mItem);
                }
            }
        });
    }

    @Override
    public int getItemCount() {
        return mValues.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {
        public final View mView;
        public final TextView txtTitle;
        public final TextView txtPrice;
        public DummyItem mItem;

        public ViewHolder(View view) {
            super(view);
            mView = view;
            txtTitle = view.findViewById(R.id.txtTitle);
            txtPrice = view.findViewById(R.id.txtPrice);
        }

        @Override
        public String toString() {
            return super.toString() + " '" + txtTitle.getText() + "'";
        }
    }
}
